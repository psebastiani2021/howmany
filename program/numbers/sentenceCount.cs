using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sentenceCharCount {
    class readLineInput {
        static void Main(string[] args) {
            string sentenceTxt = Console.ReadLine();
            uint maxTxtLength = 2147483648;
            Console.WriteLine("Maximum text length is " + maxTxtLength);
            Console.WriteLine("Input: " + sentenceTxt);
            if (sentenceTxt.Length <= 0) {
                Console.WriteLine("Your text doesn't have any characters.");
            }
            else  {
                    Console.WriteLine("Nice! Your text has " + sentenceTxt.Length + " characters");
            }
        }
    }
}
