using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using ImGuiNET;
using ClickableTransparentOverlay;
using System.ComponentModel.Design;

namespace Waw
{
    public class Program : Overlay
    {
        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess,
           bool bInheritHandle, int dwProcessId);
        static int bytesWritten = 0;

        int maxHealth;
        int moneyAmount = 0;
        int playerRunSpeed;
        bool godMode;
        bool unlimitedAmmo;
        bool thirdPerson;
        private bool _firstFrame = true;
        static async Task Main(string[] args)
        {
            Program program = new Program();
            program.Start().Wait();
        }

        protected override void Render()
        {
            try
            {
                if (_firstFrame)
                {
                    _firstFrame = false;
                    return;
                }

                var codWaw = Process.GetProcessesByName("CodWaw");
                if (codWaw.Length == 0)
                {
                    return;
                }

                IntPtr processHandle = OpenProcess(0x1F0FFF, false, codWaw[0].Id);

                if (ImGui.Begin("wawMenu"))
                {
                    ImGui.Text("WAW");
                    ImGui.Columns(2);
                    //Unlimited Ammo checkbox
                    ImGui.Checkbox("Unlimited Ammo", ref unlimitedAmmo);
                    if (unlimitedAmmo)
                    {
                        setUnlimitedAmmo(processHandle);
                    }

                    //Unlimited Health checkbox
                    ImGui.Checkbox("God Mode", ref godMode);
                    if (godMode)
                    {
                        int currentMaxHealth = retrieveHealth(processHandle, 1);
                        increaseCurrentHealth(currentMaxHealth, processHandle);
                    }

                    //Set Health
                    ImGui.Text($"Current Health: {retrieveHealth(processHandle, 2)}");
                    
                    ImGui.SliderInt("Health", ref maxHealth, 1, 10000);
                    if (ImGui.Button("Set Health"))
                    {
                        overallHealthIncrease(maxHealth, processHandle);
                    }

                    ImGui.NextColumn();

                    //setPoints
                    ImGui.SliderInt("Set Money", ref moneyAmount, 1000, 1000000);
                    if (ImGui.Button("$Set Money$"))
                    {
                        setPoints(Convert.ToInt32(moneyAmount), processHandle);
                    }
                    
                    //Set Player Speed
                    ImGui.SliderInt("Player Speed", ref playerRunSpeed, 1, 1000);
                    if (ImGui.Button("Set Player Speed!"))
                    {
                        playerSpeed(playerRunSpeed, processHandle);
                    }
                    
                    //Third-person checkbox
                    ImGui.Checkbox("Thirdperson", ref thirdPerson);
                    if (thirdPerson)
                    {
                        toggleThirdperson(processHandle, 1);
                    }
                    else
                    {
                        toggleThirdperson(processHandle, 0);
                    }
                    ImGui.Separator();
                }
                ImGui.End();
            }
            catch (Exception e)
            {
                Console.WriteLine($"ImGui Render Exception: {e}");
            }
           
        }
        static int retrieveHealth(IntPtr handler, int maxOrCurrent)
        {
            byte[] buffer = new byte[24];
            if (maxOrCurrent == 1) //0x0176C8BC -- Max Health
            {
                ReadProcessMemory((int)handler, 0x0176C8BC, buffer, buffer.Length, ref bytesWritten);
            }
            else if (maxOrCurrent == 2) //0x0176C8B8 -- Current Health
            {
                ReadProcessMemory((int)handler, 0x0176C8B8, buffer, buffer.Length, ref bytesWritten);
            }

            int currentHealth = BitConverter.ToInt32(buffer);

            return currentHealth;
        }
        static void setUnlimitedAmmo(IntPtr handler)
        {
            byte[] ammoAmount = BitConverter.GetBytes(1023);
            WriteProcessMemory((int)handler, 0x018ED1FC, ammoAmount, ammoAmount.Length, ref bytesWritten);
            WriteProcessMemory((int)handler, 0x018ED214, ammoAmount, ammoAmount.Length, ref bytesWritten);
        }
        static void setPoints(int amount, IntPtr handler)
        {
            byte[] pointAmount = BitConverter.GetBytes(amount);
            WriteProcessMemory((int)handler, 0x018EF124, pointAmount, pointAmount.Length, ref bytesWritten);
        }
        static void toggleThirdperson(IntPtr handler,int value)//0 or 1
        {
            byte[] thirdPersonByte = BitConverter.GetBytes(value);
            WriteProcessMemory((int)handler, 0x21C777C, thirdPersonByte, thirdPersonByte.Length, ref bytesWritten);
        }

        static void increaseMaxHealth(int amount, IntPtr handler)
        {
            byte[] healthAmount = BitConverter.GetBytes(amount);
            WriteProcessMemory((int)handler, 0x0176C8BC, healthAmount, healthAmount.Length, ref bytesWritten); // Writes to set Max Health
        }
        static void increaseCurrentHealth(int amount, IntPtr handler)
        {
            byte[] healthAmount = BitConverter.GetBytes(amount);
            WriteProcessMemory((int)handler, 0x0176C8B8, healthAmount, healthAmount.Length, ref bytesWritten); // Writes to set Current Health
        }
        static void overallHealthIncrease(int amount, IntPtr handler)
        {
            increaseMaxHealth(amount, handler);
            increaseCurrentHealth(amount, handler);
        }
        static void playerSpeed(int amount, IntPtr handler)
        {
            byte[] speedAmount = BitConverter.GetBytes(amount);
            WriteProcessMemory((int)handler, 0x21D7814, speedAmount, speedAmount.Length, ref bytesWritten);
        }
    }
}
