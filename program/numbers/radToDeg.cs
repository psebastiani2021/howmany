using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace radToDeg
{
	class applicationContent
	{
		static void Main(string[] args)
		{
            double radians = Convert.ToDouble(Console.ReadLine());
            double formula = radians*(180/3.1415926535897931);
            Console.WriteLine("Enter your number in radians: " + radians);
            Console.WriteLine(radians + " radians" + " is equal to " + formula + " degrees.");

		}
	}
}
