using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryClass_7_.SubclassCharacter
{
    public class Archer : Character
    {
        //ŁUCZNIK

        public int ChanceToAvoidingAnAttack { get; set; } //szansa na uniknięcie ataku

        public Archer(string name)
            :base (name, 1, 0, 20, 40, 40, 100, 100, 40, 20)
        {
            ChanceToAvoidingAnAttack = 30;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCHANCE TO AVOIDING AN ATTACK: {ChanceToAvoidingAnAttack}/10";
        }

        public override void Injuries(int injuries)
        {
            Random rand = new Random();
            if (rand.Next(1, 100) > ChanceToAvoidingAnAttack)
            {
                CurrentHealthPoints -= injuries;
            }
        }

        public override void LevelUp()
        {
            base.LevelUp();
            ChanceToAvoidingAnAttack += 5;
        }
    }
}
