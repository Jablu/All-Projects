using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 3, 10, 5, 7, 9, 11 };
            
            
            ////Traditional query syntax for collection
            //List<int> result=new List<int> ();
            //foreach (var n in numbers)
            //{
            //    if (n > 5)
            //    {
            //        result.Add(n);
            //    }
            //}

            //using Linq query
            //1. Linq using Query operators
            //var result = from n in numbers
            //             where n>5
            //             orderby n ascending
            //             select n;

            //2. Lambda operator and extension method
            var result = numbers.Where(n => n > 5).OrderByDescending(n=>n);

            //display result
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


        }
    }
}
