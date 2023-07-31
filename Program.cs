using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Smartphone Model: ");
            string smartphoneModel = Console.ReadLine();
            Smartphone smartphone = new Smartphone(smartphoneModel);
            Console.Write("Enter Laptop Model: ");
            string laptopModel = Console.ReadLine();
            Laptop laptop = new Laptop(laptopModel);
            smartphone.Connect();
            laptop.Connect();
            Console.Write("Enter Charging Time for Smartphone (in minutes): ");
            int smartphoneChargeTime = int.Parse(Console.ReadLine());

            Console.Write("Enter Charging Time for Laptop (in minutes): ");
            int laptopChargeTime = int.Parse(Console.ReadLine());

            smartphone.Charge(smartphoneChargeTime);
            laptop.Charge(laptopChargeTime);

            Console.WriteLine(smartphone.Display());
            Console.WriteLine(laptop.Display());
        }
    }
}
