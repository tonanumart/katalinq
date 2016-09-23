using LINQExample.Exams;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    
    public class TestExample
    {
        [Test]
        public void Test_LINQ_1() {
            var testArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var result = new int[]{1,3,5,7};
            Assert.AreEqual(result, FindOdds.WhereIsOddsNumbers(testArray));
            
        }

    }
}
