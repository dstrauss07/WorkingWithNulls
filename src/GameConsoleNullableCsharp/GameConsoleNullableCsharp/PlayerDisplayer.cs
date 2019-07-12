using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsoleNullableCsharp
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {

            if(string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("the player name is empty null or white space");
            }
            else
            {
                Console.WriteLine(player.Name);
            }

            //int days = player.DaysSinceLastLogin.GetValueOrDefault(-1);


            //conditional operator
                        //int days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;

            // null coalescing operator
                        int days = player.DaysSinceLastLogin ?? -1;


            Console.WriteLine($"{ days} since last login");

            //if (player.DaysSinceLastLogin.HasValue)
            //{
            //    Console.WriteLine(player.DaysSinceLastLogin.Value);
            //}
            //else
            //{
            //   Console.WriteLine("No Value for Dayssincelastlogin");
            //}
            if (player.DateOfBirth == null)
            {
                Console.WriteLine("No Value for DateOfBirth");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }

            if (player.IsNew == null)
            {
                Console.WriteLine("player newbiew status unknown");
            }
            else if(player.IsNew ==true)
            {
                Console.WriteLine("player is new");
            }
            else
            {
                Console.WriteLine("player is experienced");
            }
        }
    }
}
