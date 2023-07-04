using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace m2ToKm2
{
	class applicationContent
	{
		static void Main(string[] args)
		{
            double squaremeter = Convert.ToDouble(Console.ReadLine());
            double squarekilometer = squaremeter/1000000;
            Console.WriteLine("Enter the amount of m2: " + squaremeter);
            Console.WriteLine(squaremeter + " m2" + " is equal to " + squarekilometer + " km2.");

		}
	}
}
