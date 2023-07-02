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
            if (BMI >= 1 && BMI <= 18.5) {
                Console.WriteLine("Your BMI is considered as underweight.");
            }
            else if (BMI >= 18.51 && BMI <= 24.9) {
                Console.WriteLine("Great! Your BMI is on the healthy range.");
            }
            else if (BMI >= 25 && BMI <= 29.9) {
                Console.WriteLine("Your BMI is considered as overweight.");
            }
            else if (BMI >= 30 && BMI <= 39.9) {
                Console.WriteLine("Your BMI is considered as obese weight.");
            }
            else if (BMI >= 40) {
                Console.WriteLine("Your BMI is considered as severe obese weight.");
            }
        }
    }
}

