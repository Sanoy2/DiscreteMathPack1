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
            double numberToOperations = 5.8;
            int moduloDivide = 100;
            int moduloDivideBy = 9;
            int howLongPermutation = 3;
            int howManyPrimes = 12;
            var primes = Primes.GeneratePrimes(9);
            Console.WriteLine("Start");
            Console.WriteLine("----------");
            Console.WriteLine("Round roof:" + numberToOperations);
            Console.WriteLine(Operations.RoundRoof(numberToOperations));
            Console.WriteLine("----------");
            Console.WriteLine("Round floor: " + numberToOperations);
            Console.WriteLine(Operations.RoundFloor(numberToOperations));
            Console.WriteLine("----------");
            Console.WriteLine("Fraction part:" + numberToOperations);
            Console.WriteLine(Operations.Fraction(numberToOperations));
            Console.WriteLine("----------");
            Console.WriteLine("Modulo: {0} % {1}", moduloDivide, moduloDivideBy);
            Console.WriteLine(Modulo.Division(moduloDivide,moduloDivideBy));
            Console.WriteLine("----------");
            Console.WriteLine("First {0} primes:", howManyPrimes);
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
