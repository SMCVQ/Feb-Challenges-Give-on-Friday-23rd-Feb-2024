using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb_Challenges_Give_on_Friday_23rd_Feb_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int c = 0;
            int d = 0;
            int s = 0;
            int t = 0;
            int n1 = 0;
            int n2 = 0;
            int a = 0;

            while (c < 3 && d < 3)
            {
                t = t++;
                n1 = random.Next(1, 6);
                n2 = random.Next(1, 6);
                Console.Write(n1);
                Console.Write(n2);

                s = n1 + n2 + s;
                if (n1 == 6 || n2 == 6)
                {
                    c = c++;
                }
                if (n1 == n2)
                {
                    d = d++;
                }

             {
                    a = s / (t * 2);
                    Console.Write(c);
                    Console.Write(d);
                    Console.Write(a);
             }

                Console.ReadLine();
            }
        }
    }
}
