using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolCombination2
{
    class Program
    {
        public static int u;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet True, False için tüm kombinasyonları görmek istiyorsunuz?");
            u = Convert.ToInt32(Console.ReadLine());
            if (u != 0)
                BoolCombination1(u, "");
            
            Console.ReadKey();

        }

        static void BoolCombination1(int n, string a)
        {

            while (n == 0)
            {

                Console.WriteLine(a);
                return;
            }

            if (n != 1)
            {
                BoolCombination1(n - 1, a + "t," + " ");
                BoolCombination1(n - 1, a + "f," + " ");
            }
            else
            {
                BoolCombination1(n - 1, a + "t" + " ");
                BoolCombination1(n - 1, a + "f" + " ");
            }
        }
    }
}

