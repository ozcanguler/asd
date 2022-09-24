using System.Collections.Generic;

namespace DependencyInjectionExample
{
    internal class Gun : IWeapon
    {
        public Gun(string name, List<Bullet> bullets)
        {
            Name = name;
            Bullets = bullets;
        }

        public string Name { get; set; }
        public List<Bullet> Bullets { get; set; }

       

        public void AttackWithMe()
        {
            if(Bullets.Count>0)
            {
                System.Console.WriteLine(Name + " fires the round called "+ Bullets[0 ].Name+". The victom now has a deadly hole in him");
                Bullets.RemoveAt(0);
            }
            else
            {
                System.Console.WriteLine("The gun has no bullets. Nothing happens");
            }
        }
    }
}