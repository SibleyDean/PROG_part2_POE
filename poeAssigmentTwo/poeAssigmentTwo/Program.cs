using System;
using System.Threading.Tasks;
using poeAssigmentTwo.Services;
using poeAssigmentTwo.Structures;

namespace poeAssigmentTwo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var display = new displayASCII();
            var audio = new audioService();
            var tipsService = new tipsB();
            var chat = new ChatServ(display, tipsService);

            try
            {
                await audio.PlayGreetingAsync();
                display.ShowASCIIArt();
                string userName = chat.GetUserName();
                display.TypeWrite($"Welcome, {userName}! How can I help you with cybersecurity today?", 15);

                chat.ShowMainMenu();

                bool exitRequested = false;
                while (!exitRequested)
                {
                    Console.Write("\nYour question or choice: ");
                    string? input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        display.TypeWrite("Please enter a valid question or choice.", 10);
                        continue;
                    }

                    var sanitizedInput = input.Trim().ToLower();

                    if (sanitizedInput == "exit" || sanitizedInput == "quit" || sanitizedInput == "no")
                    {
                        exitRequested = true;
                        continue;
                    }

                    chat.ProcessUserChoice(input);

                    display.TypeWrite("\nIs there anything else you'd like to know? (yes/no)", 15);
                    var continueInput = Console.ReadLine()?.Trim().ToLower();
                    if (continueInput == "no" || continueInput == "exit" || continueInput == "quit")
                    {
                        exitRequested = true;
                    }
                    else if (continueInput == "menu")
                    {
                        chat.ShowMainMenu();
                    }
                }
            }
            finally
            {
                audio.Dispose();
                display.TypeWrite("\nThank you for using the Cybersecurity Bot. Stay safe online!", 15);
            }
        }
    }
}