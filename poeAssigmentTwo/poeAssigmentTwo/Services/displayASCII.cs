using System;
using System.Threading;
using poeAssigmentTwo.Structures;

namespace poeAssigmentTwo.Services
{
    public class displayASCII
    {
        public void TypeWrite(string message, int speedMs = 20)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(speedMs);
            }
            Console.WriteLine();
        }

        public void ShowASCIIArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
  ____              _ _       \ \
    .-""""""-. / \_> /\    |/
   /         \.'`  `',.--//
 -(Y2K I      I  @@\
   \         /'.____.'\___|
    '-.....-' __/ | \   (`)
jgs          /   /  /
                 \  \
Y2K bug by Joan G.Stark
        ");
            Console.ResetColor();
        }

        public void ShowTopic(responseB response, int responseIndex = 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n=== {response.Title} ===");
            Console.ResetColor();

            if (response.RandomResponses != null && response.RandomResponses.Length > 0)
            {
                // Bound check
                responseIndex = Math.Clamp(responseIndex, 0, response.RandomResponses.Length - 1);
                TypeWrite(response.RandomResponses[responseIndex], 10);
            }
            else
            {
                TypeWrite("No information available for this topic.", 10);
            }

            if (response.FollowUps != null && response.FollowUps.Length > 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                TypeWrite("\nRelated topics you might want to explore next:", 10);
                foreach (var followUp in response.FollowUps)
                {
                    TypeWrite($"- {followUp}", 10);
                }
                Console.ResetColor();
            }
        }
    }
    }