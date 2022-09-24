using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    class HeroThatOnlyUsesSword : IHero
    {
        public HeroThatOnlyUsesSword(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public void Attack()
        {
            Sword sword = new Sword("Zulfiqar");
            Console.WriteLine(Name+ " Prepares himself for the battle.");
            sword.AttackWithMe();

        }
    }
}
