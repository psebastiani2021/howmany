using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace inToCm
{
	class applicationContent
	{
		static void Main(string[] args)
           {
			double inches = Convert.ToDouble(Console.ReadLine());
            double centimeters = inches*2.54;
            Console.WriteLine("Enter the amount of inches: " + inches);
            Console.WriteLine(inches + " is equal to " + centimeters + " exact centimeters.");
            }
	}
}
