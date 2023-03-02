using System;
using System.Text;
using System.Runtime.InteropServices;
using DiscordRPC;//Requires the download of C# Discord RPC Wrapper https://github.com/Lachee/discord-rpc-csharp
using System.IO;

namespace getCurrentApplication
{
    class Program
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(uint processAccess, bool bInheritHandle, int processId);
        [DllImport("psapi.dll")]
        static extern uint GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, [Out] StringBuilder lpBaseName, [In][MarshalAs(UnmanagedType.U4)] int nSize);
        
        static void Main(string[] args)
        {
            DiscordRpcClient client = new DiscordRpcClient("");//Pass your bot client ID in here and if the bot has images uploaded to it, then it will work fine.
            client.Initialize();
            string currentWindow = getApplication().Item1;
            string currentApp = getApplication().Item2;
            string NewProcess;
            Timestamps time = null;
            while (true)
            { 
                if (currentWindow != getApplication().Item1)
                {
                    currentWindow = getApplication().Item1;
                    if (currentWindow.Length >= 128)
                    {
                        NewProcess = $"{currentWindow.Substring(0, 124)}...";
                    }
                    else
                    {
                        NewProcess = currentWindow;
                    }
                    if (client.CurrentPresence && client.CurrentPresence.HasTimestamps())
                    {
                        time = client.CurrentPresence.Timestamps;
                    }
                    if (currentApp != getApplication().Item2)
                    {
                        currentApp = getApplication().Item2;
                        time = null;
                    }
                    client.SetPresence(new RichPresence()
                    {
                        Details = NewProcess,
                        Timestamps = !(time is null) ? time : Timestamps.Now,
                        Assets = new Assets()
                        {
                            LargeImageKey = getFileName(currentApp)//To add more images, update getFileName function with image key names from discord developer portal.
                        }
                    });
                }
            }
        }

        static IntPtr getActiveWindow()
        {
            IntPtr handle = IntPtr.Zero;
            handle = GetForegroundWindow();

            return handle;
        }

        static (string,string) getApplication()
        {
            IntPtr handle = getActiveWindow();
            int nChar = 4000;
            StringBuilder ss = new StringBuilder(nChar);
            uint pid = 0;

            GetWindowThreadProcessId(handle, out pid);
            var processHandle = OpenProcess(0x0400 | 0x0010, false, (int)pid);
            string result = null;

            if (GetModuleFileNameEx(processHandle, IntPtr.Zero, ss, nChar) > 0)
            {
                result = Path.GetFileName(ss.ToString());
            }

            GetWindowText(handle, ss, nChar);//To set window I'll try using the window handle, run a switch case on it 

            return (ss.ToString(),result);
        }

        static string getFileName(string result)
        {
            switch (result)
            {
                //
                //For all of the images that you want, put the application name in here
                //and upload the images with the key which is returned to your discod developer portal.
                //
                case "chrome.exe":
                    return "chrome";
                case "Code.exe":
                    return "vscode";
                case "devenv.exe":
                    return "visualstudio";
                case "Discord.exe":
                    return "discord";
                case "Spotify.exe":
                    return "spotify";
                case "steam.exe":
                    return "steam";
                default:
                    return "";
            }
        }
    }
}
