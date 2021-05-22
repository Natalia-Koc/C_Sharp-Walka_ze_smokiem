using LibraryClass_7_;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplicationTests_7_
{
    public delegate void MyDelegate(int x);
    class Dragon : Character
    {
        public event MyDelegate myDelegate;

        public Dragon(String name)
            :base (name, 3, 15, 15, 15, 15, 500, 500, 30, 30)
        {
            
        }

        public int DragonBreathesFire()
        {
            myDelegate?.Invoke(Power + DamageDealt + Level);
            Console.WriteLine($"{Name} the dragon breathes fire at an intensity of {Power + DamageDealt + Level}");
            return (Power + DamageDealt + Level);
        }

        public void Damge(int points)
        {
            CurrentHealthPoints -= (points - DamageResistance);
        }
    }
}
