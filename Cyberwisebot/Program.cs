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
            StartConversation();


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
        static void StartConversation()
        {
            Console.Write("Hello! What's your name? ");
            string name = Console.ReadLine() ?? "User"; // Fixes possible null value
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Hello, {name}! Welcome to the Cyberwise Chatbot.");
            Console.ResetColor();

            // First question
            Console.Write("What is your purpose? ");
            string purpose = Console.ReadLine() ?? "Unknown"; // Fixes possible null value
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Wow, that's great!");
            Console.ResetColor();

            // Second question
            Console.Write("What is your favorite color? ");
            string color = Console.ReadLine() ?? "Unknown"; // Fixes possible null value
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"That's a lovely color, {name}!");
            Console.ResetColor();

            // Third question
            Console.Write("Are you excited to learn about cybersecurity? (yes/no) ");
            string response = (Console.ReadLine() ?? "").Trim().ToLower();

            if (response == "yes")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Great! Ask a cybersecurity question or type 'exit' to quit.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That's a shame, but still, ask a cybersecurity question or type 'exit' to quit.");
                Console.ResetColor();
            }

            // Start the cybersecurity Q&A chat
            CybersecurityChat();
        }

        static void CybersecurityChat()
        {
            // Cybersecurity questions and responses dictionary
            Dictionary<string, string> cybersecurityResponses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"What is cybersecurity","Cybersecurity is the practice of protecting digital devices,networks, and sensitive data from cyber threats such as hacking,malware ,and phishing attacks."},
            { "what is safe browsing", "Safe browsing means using strong passwords, avoiding suspicious links, and keeping software updated." },
            { "what is two-factor authentication", "Two-factor authentication (2FA) is an extra security step requiring a second verification method." },
            { "what is phishing", "Phishing is a cyberattack where scammers trick users into revealing sensitive information." },
            { "how do I create a strong password", "A strong password includes a mix of uppercase, lowercase, numbers, and special characters." },
            { "how can I protect myself online", "You can stay safe by using strong passwords, enabling 2FA, and avoiding suspicious links." },
            { "what is malware", "Malware is malicious software that can damage or steal information from your device." },
            { "what is ransomware", "Ransomware is a type of malware that locks your files and demands payment to unlock them." }
        };

            // Start a loop for chatting
            while (true)
            {
                Console.Write("\nAsk a cybersecurity question or type 'exit' to quit: ");
                string userInput = Console.ReadLine()?.Trim().ToLower() ?? ""; // Fixes possible null value

                if (userInput == "exit") break;

                // Check if the question exists in the dictionary and respond accordingly
                if (cybersecurityResponses.TryGetValue(userInput, out string response)) // Fixes possible null reference
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(response);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I'm not sure about that. Try asking something about cybersecurity!");
                    Console.ResetColor();
                }
            }

            // End the conversation  & Project 
            Console.WriteLine("Goodbye! Stay safe online.");
        }
    }
}