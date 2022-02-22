using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coure_test_array
{
    class Program
    {
        static void Main(string[] args)
        {


            //int[] input = {15,25,35 };
            int i, n, even = 0, odd = 0, eight = 0;
            int evenpoint = 1;
            int oddpoint = 3;
            int epghtpoint = 5;

            Console.WriteLine("Enter the number of elements to be inserted: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter the array elements:");
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    even = even;
                    even++;

                    if (a[i] == 8) { eight = eight; eight++; }
                }

                else
                {
                    odd = odd;
                    odd++;
                }

            }

            int totaleven = even * evenpoint;
            int totaodd = odd * oddpoint;
            int totaleight = eight * epghtpoint;

            int output = totaleven + totaodd + totaleight;
            Console.WriteLine(" Output is  => : " + output);
            Console.ReadLine();
        }
    }
}
