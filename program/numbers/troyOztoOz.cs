using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace troyOztoOz {
  class applicationContent {
    static void Main(string[] args) {
      double troyOz =  Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter amount in troy ounces: ");
      double oz = Convert.ToDouble(Console.ReadLine());
      double oz = troyOz*1.09714;
      Console.ReadLine(troyOz + "troy ounces are equal to " + oz + "ounces.");
    }
  }
}
