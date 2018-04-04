using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscreteMathPack1;

namespace testConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberToOperations = -5.8;
            int moduloDivide = 105;
            int moduloDivideBy = 9;
            int howLongPermutation = 30;
            int howManyPrimes = 10;
            var primes = Primes.GeneratePrimes(howManyPrimes);
            Console.WriteLine("Start");
            Console.WriteLine("----------");
            Console.WriteLine("Round roof: " + numberToOperations);
            Console.WriteLine("Result: ");
            Console.WriteLine(Operations.RoundRoof(numberToOperations));
            Console.WriteLine("----------");
            Console.WriteLine("Round floor: " + numberToOperations);
            Console.WriteLine("Result: ");
            Console.WriteLine(Operations.RoundFloor(numberToOperations));
            Console.WriteLine("----------");
            Console.WriteLine("Fraction part: " + numberToOperations);
            Console.WriteLine("Result: ");
            Console.WriteLine(Operations.Fraction(numberToOperations));
            Console.WriteLine("----------");
            Console.WriteLine("Modulo: {0} % {1}", moduloDivide, moduloDivideBy);
            Console.WriteLine("Result: ");
            Console.WriteLine(Modulo.Division(moduloDivide,moduloDivideBy));
            Console.WriteLine("----------");
            Console.WriteLine("First {0} primes:", howManyPrimes);
            Console.WriteLine("Result: ");
            Primes.WriteList(primes);
            Console.WriteLine("----------");
            Console.WriteLine("Permutations of {0} numbers:", howLongPermutation);
            Permutation.WritePermutations(howLongPermutation);
            Console.WriteLine("----------");

            Console.WriteLine("\n\n\n Done");

            Console.ReadKey();
        }
    }
}
