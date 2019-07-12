using System;

namespace GameConsoleNullableCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            PlayerCharacter sarah = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "sarah"
            };

            PlayerCharacter amrit = new PlayerCharacter(new IronBones())
            {
                Name = "amrit"
            };

            PlayerCharacter gentry = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "gentry"
            };

            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);



            Console.ReadLine();

            //var player = new PlayerCharacter();

            ////PlayerCharacter player = null;

            //player.DaysSinceLastLogin = 10;
            ////PlayerDisplayer.Write(player);

            ////int days = player.DaysSinceLastLogin.Value;
            ////null conditional operator
            //int days = player?.DaysSinceLastLogin ?? -1;



            //Console.WriteLine(days);


            //PlayerCharacter[] players = new PlayerCharacter[3]
            //{
            //    new PlayerCharacter{Name="sarah'"},
            //    new PlayerCharacter(),
            //    null
            //};

            //string p1 = players[0]?.Name;
            //string p2 = players[1]?.Name;
            //string p3 = players[2]?.Name;

            //Console.ReadLine();
        }
    }
}
