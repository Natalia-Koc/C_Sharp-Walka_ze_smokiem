using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryClass_7_.SubclassCharacter
{
    public class Warrior : Character
    {
        //WOJOWNIK

        public int NumberAttacks { get; set; } //liczba atatków na rundę 

        public Warrior(string name)
            : base(name, 1, 0, 50, 30, 20, 100, 100, 70, 40)
        {
            NumberAttacks = 2;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nNUMBER OF ATTACKS PER ROUND: {NumberAttacks}";
        }

        public override void LevelUp()
        {
            base.LevelUp();
            NumberAttacks += 2;
        }
    }
}
