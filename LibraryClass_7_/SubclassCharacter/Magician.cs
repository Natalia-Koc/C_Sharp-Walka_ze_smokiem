using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryClass_7_.SubclassCharacter
{
    public class Magician : Character
    {
        public int CurrentManaPoints { get; set; }
        public int MaximumManaPionts { get; set; }

        public Magician(string name)
            : base(name, 1, 0, 15, 50, 50, 100, 100, 40, 20)
        {
            CurrentManaPoints = 1;
            MaximumManaPionts = 100;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nMANA POINTS: {CurrentHealthPoints}/{MaximumHealthPoints}";
        }

        public override void LevelUp()
        {
            base.LevelUp();
            CurrentManaPoints += 2;
        }
    }
}
