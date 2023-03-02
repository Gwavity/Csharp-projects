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
            string NewProcess;
            client.Initialize();
            string currentApp = getApplicationName();
            string currentWindow = getApplicationName();
            while (true)
            { 
                if (currentWindow != getApplicationName())
                {
                    currentWindow = getApplicationName();
                    if(currentWindow.Length > 50)
                    {
                        NewProcess = $"{currentWindow.Substring(0, 45)}...";
                    }
                    else
                    {
                        NewProcess = currentWindow.Substring(0, currentWindow.Length);
                    }

                    client.SetPresence(new RichPresence()
                    {
                        Details = NewProcess,
                        Timestamps = Timestamps.Now,
                        Assets = new Assets()
                        {
                            LargeImageKey = getFileName()//To add more images, update getFileName function with image key names from discord developer portal.
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
        
        static string getApplicationName()
        {
            IntPtr handle = getActiveWindow();
            int nChar = 4000;
            StringBuilder ss = new StringBuilder(nChar);

            GetWindowText(handle, ss, nChar);//To set window I'll try using the window handle, run a switch case on it 

            return ss.ToString();
        }
        
        static string getFileName()
        {
            IntPtr handle = getActiveWindow();
            int nChar = 4000;
            StringBuilder ss = new StringBuilder(nChar);
            uint pid = 0;

            GetWindowThreadProcessId(handle, out pid);
            var processHandle = OpenProcess(0x0400 | 0x0010, false, (int)pid);
            string result = null;

            if (GetModuleFileNameEx(processHandle, IntPtr.Zero, ss, 4000) > 0)
            {
                result = Path.GetFileName(ss.ToString());
            }

            switch(result)
            {
            //
            //For all of the images that you want, put the application name in here
            //and upload the images with the key which is returned to your discod developer portal.
            //
                case "chrome.exe":
                    return "chrome";
                case "Discord.exe":
                    return "discord";
                case "Spotify.exe":
                    return "spotify";
                case "steam.exe":
                    return "steam";
                default:
                    return "";//
            }
        }
    }
}
