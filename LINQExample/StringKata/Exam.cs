using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample.StringKata
{
    [TestFixture]
    public class Exam
    {
        [Test]
        public void Test_SumOfNo6()
        {
            Assert.AreEqual("0+1+2+3+4+5+6 = 21", StringKata.SumOfNum(6));
        }

        [Test]
        public void Test_SumOfNoNegative()
        {
            Assert.AreEqual("-15<0", StringKata.SumOfNum(-15));
        }

        [Test]
        public void Test_SumOfNoZero()
        {
            Assert.AreEqual("0=0", StringKata.SumOfNum(0));
        }

        [Test]
        public void Test_SumOfNo10()
        {
            Assert.AreEqual("0+1+2+3+4+5+6+7+8+9+10 = 55", StringKata.SumOfNum(10));
        }

    }
}
