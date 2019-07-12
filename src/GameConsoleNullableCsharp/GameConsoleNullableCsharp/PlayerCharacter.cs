using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsoleNullableCsharp
{
    class PlayerCharacter
    {
        private readonly SpecialDefence _specialDefence;

        public PlayerCharacter(SpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
        }

        public string Name { get; set; }

        public int Health { get; set; } = 100;

        public void Hit(int damage)
        {
            //int damageReduction = 0;

            //damageReduction = _specialDefence.CalculateDamageReduction(damage);

            //int totalDamageTaken = damage - damageReduction;

            int totalDamageTaken = damage - _specialDefence.CalculateDamageReduction(damage);

            Health -= totalDamageTaken;

            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}.");
        }

        public int? DaysSinceLastLogin { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public bool? IsNew { get; set; }

        //Nullable<T> - shorthand used above ?

        //public PlayerCharacter()
        //{
        //    //DateOfBirth = DateTime.MinValue; //magic number
        //    //DaysSinceLastLogin = -1; // magic number
        //    DateOfBirth = null;
        //    DaysSinceLastLogin = null;
        //}
        //constructor is not needed when using nullable value type.
    }
}
