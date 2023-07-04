using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace minToSeg
{
	class applicationContent
	{
		static void Main(string[] args)
		{
            double minutes = Convert.ToDouble(Console.ReadLine());
            double seconds = minutes*60;
            Console.WriteLine("Enter the amount of minutes: " + minutes);
            Console.WriteLine(minutes + " minutes" + " is equal to " + seconds + " seconds.");

		}
	}
}
