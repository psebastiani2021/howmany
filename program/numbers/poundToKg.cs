using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace poundToKg
{
	class applicationContent
	{
		static void Main(string[] args)
		{
            double pound = Convert.ToDouble(Console.ReadLine());
            double kilograms = pound/2.205;
            Console.WriteLine("Enter the amount of pounds: " + pound);
            Console.WriteLine(pound + " pound(s)" + " is equal to " + kilograms + " kilograms, approximately.");

		}
	}
}

