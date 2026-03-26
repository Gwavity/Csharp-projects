using System;
using System.Diagnostics;
using System.Threading;

namespace spotify_kill
{
    class Program
    {
        public static void Main()
        {
            Console.Title = "Spotify Killer";
            string spotifyPath = "";
            Process[] Spotify = Process.GetProcessesByName("Spotify");
            if (Spotify.Length >= 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Restarting Spotify.\n");
                foreach (Process currentProcess in Spotify)
                {
                    spotifyPath = currentProcess.MainModule.FileName;
                    currentProcess.Kill();
                }
                Process.Start(spotifyPath);
                Thread.Sleep(2000);
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You are not currently running Spotify... Exiting.");
                Thread.Sleep(2000);
                return;
            }
        }
    }
}
