using LINQExample.Exams;
using LINQExample.Model;
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
        public void Test_LINQ_Where()
        {
            var testArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var result = new int[] { 1, 3, 5, 7 };
            Assert.AreEqual(result, ExampleLinqTest.WhereIsOddsNumbers(testArray));
        }

        [Test]
        public void Test_LINQ_Find_EvenLengthString()
        {
            var mString = new string[] { "anumart", "siwat", "dataeven" };
            Assert.AreEqual("dataeven", ExampleLinqTest.EvenLengthString(mString));
        }

        [Test]
        public void FindSumOfOrdersThis() {
            var orders = new List<Order>();
            orders.Add(new Order(){ Price = 50m });
            orders.Add(new Order() { Price = 18m });
            orders.Add(new Order() { Price = 20m });
            orders.Add(new Order() { Price = 7.5m });
            Assert.AreEqual(95.5, ExampleLinqTest.GetSumOfOrders(orders));
        }

        [Test]
        public void FindPriceMoreThan20()
        {
            var orders = new List<Order>();

            var price50 = new Order() { Price = 50m };
            orders.Add(price50);
            orders.Add(new Order() { Price = 10m });
            var price30 = new Order() { Price = 30m };
            orders.Add(price30);
            orders.Add(new Order() { Price = 1.5m });

            var result = new List<Order>();
            result.Add(price50);
            result.Add(price30);
            Assert.AreEqual(result, ExampleLinqTest.GetOrdersPriceMoreThanOrEqual20(orders));
        }


        [Test]
        public void FindAEIOU()
        {
            string longString = "asjdgqyweu1237865weasydgajet32ayusdhqii132uijasdhkjcetewfy1523rysada9dasiodjqldlwek,goepripas[ldzjxcnvzhxdfqtywieuty231546";
            Assert.AreEqual(29, ExampleLinqTest.CountAeiou(longString));
        }

        [Test]
        public void WantOnlyMod7AndPlus1()
        {
            int[] series = new int[]{1,3,5,6,7,8,9,14,21,18,32,19,55,42,49,14,7};
            var result = new int[] { 8, 15, 22, 43, 50, 15, 8 };
            Assert.AreEqual(result, ExampleLinqTest.Mod7AndPlus1(series));
        }


    }
}
