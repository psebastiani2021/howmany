using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace yardToKm
{
	class applicationContent
	{
		static void Main(string[] args)
		{
            double yards = Convert.ToDouble(Console.ReadLine());
            double kilometers = yards/1094;
            Console.WriteLine("Enter the amount of yards: " + yards);
            Console.WriteLine(yards + " yards" + " is equal to " + kilometers + " exact kilometers.");
		}
	}
}
