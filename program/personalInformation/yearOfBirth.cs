using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcYearBirth {
  class applicationContent {
    static void Main(string[] args) {
      int age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter your age: " + age);
      if (age <= 0) {
        Console.WriteLine("Error: Your age must be somewhere between 1 and 106.");
      } else if (106 <= age) {
        Console.WriteLine("Error: Your age must be equal to or lower than 106.");
      } else {
        Console.WriteLine("Your age is valid! Calculating...");
        int currentYear = DateTime.Now.Year;
        Console.WriteLine("You were born in " + (currentYear - age));
      }
    }
  }
}
