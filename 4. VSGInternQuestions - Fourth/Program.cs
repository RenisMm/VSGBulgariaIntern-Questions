using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.VSGInternQuestions___Fourth
{
    class Weapon : Weapons
    {
        public override void WeaponType(WeaponType type, string action, int damage)
        {
            Console.WriteLine($"{type} {action} for {damage} damage!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a type of gun, 0 for a gun, 1 for a knife and 2 for a bow: ");
            int type = Int32.Parse(Console.ReadLine());
            var wep = (WeaponType)type;

            if (type > 2 || type < 0)
            {
                Console.WriteLine("The input should be between 0 and 2!");
                return;
            }
            else
            {
                Console.WriteLine("Instantiated a " + wep + "");
                inflickDamage(type);

                Weapon weapon = new Weapon();
                weapon.WeaponType(wep, ActionOfWeapon(type), Int32.Parse(inflickDamage(type)));
            }
        }

        static string inflickDamage(int number)
        {
            switch (number)
            {
                case 0:
                    return "20";
                case 1:
                    return "10";
                case 2:
                    return "5";
                default:
                    return "Not valid weapon!";
            }
        }

        static string ActionOfWeapon(int number)
        {
            switch (number)
            {
                case 0:
                    return "shoots";
                case 1:
                    return "stabs";
                case 2:
                    return "shoots an arrow";
                default:
                    return "Not valid weapon!";
            }
        }
    }
}
