using System;

namespace ConsoleApp3
{
    class Unit
    {
        public string name;
        public int health;
        public int Maxhealth;

        public Unit(string name, int health, int Maxhealth)
        {
            this.name = name;
            this.health = health;
            this.Maxhealth = Maxhealth;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"유닛:{name}");
            Console.WriteLine($"체력:{health}");
            Console.WriteLine($"최대체력:{Maxhealth}");
        }
    }

    class Marine : Terran
    {
        public Marine()
        {
            health = 40;
            maxHealth = health;
        }

        public override void Recovery()
        {
            health = maxHealth;
            Console.WriteLine("health:" + health);
        }
    }
    class Firebet : Terran
    {
        public Firebet()
        {
            health = 50;
            maxHealth = health;
        }

        public override void Recovery()
        {
            health = maxHealth;
            Console.WriteLine("health:" + health);
        }
    }

    class Ghost : Terran
    {
        public Ghost()
        {
            health = 45;
            maxHealth = health;
        }

        public override void Recovery()
        {
            health = maxHealth;
            Console.WriteLine("health:" + health);
        }
    }

   

    internal class Program
    {
        static void Beacon(Terran terran)
        {
            terran.Recovery();
        }

        static void Main(string[] args)
        {
           Marine marine = new Marine();
           
           Firebet firebet = new Firebet();
           Ghost ghost = new Ghost();

            marine.Health -= 10;
            firebet.Health -= 10;
            ghost.Health -= 10;

            Beacon(marine);
            Beacon(firebet);
            Beacon(ghost);

        }
    }
}
