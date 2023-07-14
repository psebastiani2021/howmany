using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fluidOuncesToLiters
{
	class applicationContent
	{
		static void Main(string[] args)
		{
			double fluidOunces = Convert.ToDouble(Console.ReadLine());
            double liters = fluidOunces/33.814;
            Console.WriteLine("Enter the amount of fluid ounces: " + fluidOunces);
            Console.WriteLine(fluidOunces + " fluid ounces are equal to " + Math.Round(liters, 7) + " liters.");
 		}
	}
}
