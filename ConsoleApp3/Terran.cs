using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal abstract class Terran
    {
        protected int health;
        protected int maxHealth;

        public int Health
        {
            get { return health; }
            set 
            {
                if(maxHealth < value)
                {
                    Console.WriteLine("");
                    return;
                }

                health = value;
                Console.WriteLine("health의 값: " + health);
            }
        }
        
        public abstract void Recovery();
    }
}
