using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            HeroThatOnlyUsesSword hero = new HeroThatOnlyUsesSword("Flame");
            hero.Attack();
            Console.WriteLine();
            HeroThatCanUseAnyWeapon hero1 = new HeroThatCanUseAnyWeapon("Sacred", new Grenade("pineapple"));
            hero1.Attack();
            Console.WriteLine();
            HeroThatCanUseAnyWeapon hero2 = new HeroThatCanUseAnyWeapon("Vulgar", new Grenade("Star"));
            hero2.Attack();
            Console.WriteLine();
            HeroThatCanUseAnyWeapon hero3 = new HeroThatCanUseAnyWeapon("Terminator", new Gun("Mossberg",new List<Bullet> {new Bullet("magnum",10), new Bullet("lead",20), new Bullet("dead aim",3), new Bullet("Hollow Point",5) }));
            hero3.Attack();
                 hero3.Attack();
            hero3.Attack();
            hero3.Attack();
            hero3.Attack();
            hero3.Attack();
            Console.ReadLine();
        }
    }
}
