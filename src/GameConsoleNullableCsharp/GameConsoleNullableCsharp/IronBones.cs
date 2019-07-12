using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsoleNullableCsharp
{
    public class IronBones : SpecialDefence
    {
        public override int CalculateDamageReduction(int totalDamage)
        {
            return 5;
        }
    }
}
