using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    class HeroThatCanUseAnyWeapon:IHero
    {
        public HeroThatCanUseAnyWeapon(string name, IWeapon myWeapon)
        {
            Name = name;
            MyWeapon = myWeapon;
        }

        public string Name { get; set; }
        public IWeapon MyWeapon { get; set; }

        public void Attack()
        {
            Console.WriteLine(Name+ " prepares to attack");
            MyWeapon.AttackWithMe();
        }
    }
}
