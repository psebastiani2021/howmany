using System;

namespace calcYearBirth
{
	class applicationContent
	{
		static void Main(string[] args)
		{
			int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your age: " + age);
            if (age <= 0) {
                Console.WriteLine("Your age is not valid.");
            }
            else if (106 <= age) {
                Console.WriteLine("Your age must be equal to or lower than 106.");
            }
            else {
                Console.WriteLine("Your age is valid! Calculating...");
                int currentYear = DateTime.Now.Year;
                Console.WriteLine("You were born in " + (currentYear-age));
            }
		}
	}
}
