using LINQExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample.Exams
{
    public class ExampleLinqTest
    {
        public static int[] WhereIsOddsNumbers(int[] array) 
        {
            return array.Where(value => value % 2 == 1).ToArray();
        }

        public static string EvenLengthString(string[] mString)
        {
            return mString.Where(value => value.Length % 2 == 0).First();
        }

        public static decimal GetSumOfOrders(List<Model.Order> orders)
        {
            return orders.Sum(value => value.Price);
        }

        public static List<Order> GetOrdersPriceMoreThanOrEqual20(List<Model.Order> orders)
        {
            return orders.Where(value => value.Price >= 20).ToList();
        }

        public static int CountAeiou(string longString)
        {   //ignore case A = a
            return longString.Count(str => str == 'a' || str == 'e' || str == 'i' || str == 'o' || str == 'u');
        }

        public static int[] Mod7AndPlus1(int[] series)
        {
            int[] onlyMod7AndPlus1 = series.Where(value => value % 7 == 0  ).ToArray();

            return onlyMod7AndPlus1.Select(data => data + 1).ToArray();
        }
    }
}
