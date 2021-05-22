using System;

namespace LibraryClass_7_
{
    public class Character : IComparable
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int ExperciencePoints { get; set; }//punkty doświadczenia
        public int Power { get; set; }
        public int Skill { get; set; }//zręczność
        public int Intelligence { get; set; }
        public int CurrentHealthPoints { get; set; }
        public int MaximumHealthPoints { get; set; }
        public virtual int DamageDealt { get; set; }//zadawane obrażenia
        public int DamageResistance { get; set; }//odporność na obrażenia

        protected Character()
        {
        }

        public Character(string name, int level, int experciencePoints, int power, int skill,
            int intelligence, int currentHealthPoints, int maximumHealthPoints, int damageDealt, int damageResistance)
        {
            Name = name;
            Level = level;
            ExperciencePoints = experciencePoints;
            Power = power;
            Skill = skill;
            Intelligence = intelligence;
            CurrentHealthPoints = currentHealthPoints;
            MaximumHealthPoints = maximumHealthPoints;
            DamageDealt = damageDealt;
            DamageResistance = damageResistance;
        }

        public new virtual string ToString()
        {
            return $"NAME: {Name}\n" +
                $"LEVEL: {Level}\n" +
                $"EXPERIENCE POINTS: {ExperciencePoints}/100\n" +
                $"POWER: {Power}/100\n" +
                $"SKILL: {Skill}/100\n" +
                $"INTELLIGENCE: {Intelligence}/100\n" +
                $"HEALTH POINTS: {CurrentHealthPoints}/{MaximumHealthPoints}\n" +
                $"DAMAGE DEALT: {DamageDealt}/100\n" +
                $"DAMAGE RESISTANCE: {DamageResistance}/100";
        }

        public void ArmingCharacter(int arming)
        {
            DamageDealt += arming;
        }

        public void PutOnArmor(int armor)
        {
            DamageResistance += armor;
        }

        public virtual void Injuries(int injuries)
        {
            CurrentHealthPoints -= (injuries - DamageResistance);
            if (CurrentHealthPoints < 0)
                CurrentHealthPoints = 0;
        }

        public virtual void LevelUp()
        {
            Level += 1;
            ExperciencePoints += 10;
            Power += 10;
            Skill += 10;
            Intelligence += 10;
            CurrentHealthPoints = 100;
            DamageDealt += 10;
            DamageResistance += 10;
        }

        public int CompareTo(Object obj)
        {
            return this.Level.CompareTo(obj);
        }
    }
}
