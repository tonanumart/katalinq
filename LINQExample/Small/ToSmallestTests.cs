using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample.Small
{
    [TestFixture]
    class ToSmallestTests
    {

        //You have a positive number n consisting of digits. You can do at most one operation: Choosing the index of a digit in the number, remove this digit at that index and insert it back to another place in the number.

        //Doing so, find the smallest number you can get.

        //Task:

        //Return an array or a tuple depending on the language (see "Your Test Cases" Haskell) with

        //1) the smallest number you got
        //2) the index i of the digit d you took, i as small as possible
        //3) the index j (as small as possible) where you insert this digit d to have the smallest number.
        //Example:

        //smallest(261235) --> [126235, 2, 0]
        //126235 is the smallest number gotten by taking 1 at index 2 and putting it at index 0

        //smallest(209917) --> [29917, 0, 1]

        //[29917, 1, 0] could be a solution too but index `i` in [29917, 1, 0] is greater than 
        //index `i` in [29917, 0, 1].
        //29917 is the smallest number gotten by taking 2 at index 0 and putting it at index 1 which gave 029917 which is the number 29917.

        //smallest(1000000) --> [1, 0, 6]

        private static void testing(long n, string res)
        {
            Assert.AreEqual(res, Array2String(ToSmallest.Smallest(n)));
        }
        private static string Array2String(long[] list)
        {
            return "[" + string.Join(", ", list) + "]";
        }
        [Test]
        public static void test1()
        {
            Console.WriteLine("Basic Tests smallest");
            testing(261235, "[126235, 2, 0]");
            testing(209917, "[29917, 0, 1]");
            testing(285365, "[238565, 3, 1]");
            testing(269045, "[26945, 3, 0]");
            testing(296837, "[239687, 4, 1]");
        }

    }
}
