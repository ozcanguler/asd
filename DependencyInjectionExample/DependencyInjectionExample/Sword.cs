namespace DependencyInjectionExample
{
    internal class Sword:IWeapon
    {
        public Sword(string swordName)
        {
            SwordName = swordName;
        }

        public string SwordName { get; set; }
        public void AttackWithMe()
        {
            System.Console.WriteLine(SwordName+ " Cleaver of the spine");
        }
    }
}