using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Cyberwisebot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayVoiceGreeting();
            DisplayAsciiArt();

        }
        static void PlayVoiceGreeting()
        {
            SoundPlayer soundPlayer = new SoundPlayer("greeting.wav");
            soundPlayer.Load();
            soundPlayer.PlaySync();
        }
        static void DisplayAsciiArt()
        {
            // Display the ASCII art in green
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
  ██████╗██╗   ██╗██████╗ ███████╗██╗    ██╗██╗███████╗███████╗
 ██╔════╝██║   ██║██╔══██╗██╔════╝██║    ██║██║██╔════╝██╔════╝
 ██║     ██║   ██║██████╔╝█████╗  ██║ █╗ ██║██║█████╗  █████╗  
 ██║     ██║   ██║██╔═══╝ ██╔══╝  ██║███╗██║██║██╔══╝  ██╔══╝  
 ╚██████╗╚██████╔╝██║     ███████╗╚███╔███╔╝██║██║     ██║     
  ╚═════╝ ╚═════╝ ╚═╝     ╚══════╝ ╚══╝╚══╝ ╚═╝╚═╝     ╚═╝     
        ");
            Console.ResetColor();
        }



    }
}
