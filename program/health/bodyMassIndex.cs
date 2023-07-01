using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bodyMassIndex
{
    class applicationContent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight in kilograms:");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height in centimeters:");
            double height = Convert.ToDouble(Console.ReadLine()) / 100;
            double BMI = weight / (height * height);
            Console.WriteLine("Your weight: " + weight + " kg");
            Console.WriteLine("Your height: " + height + " m");
            Console.WriteLine("Your approximated BMI is: " + Math.Round(BMI, 2));
            Console.WriteLine("Your specific BMI is: " + BMI);
        }
    }
}
