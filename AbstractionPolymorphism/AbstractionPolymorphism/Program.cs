using System;

namespace AbstractionPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sword sword1 = new Sword();
            sword1.Attack();

            Console.WriteLine();
            MagicStaff staff1 = new MagicStaff();
            staff1.Attack();
            staff1.Charge();
            staff1.Attack();

            Console.WriteLine();
            Pistol pistol1 = new Pistol();
            pistol1.Attack();

            Console.WriteLine();
        }
    }
}
