using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_sayilari_ile_ortalama_hesaplama
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int i, a = 0, b = 1, c = 0;
            double ortalama = 0, sayac, toplam = 0, x = 0;

            Console.Write("Bir sayı giriniz : ");
            sayac = Convert.ToInt32(Console.ReadLine());

            Console.Write("Fibonacci serisi : " + a);

            for (i = 1; i < sayac; i++)
            {
                c = a + b;
                a = b;
                b = c;
                toplam += a;

                Console.Write("-" + a);
            }

            ortalama = toplam / sayac;
            x = Math.Round(ortalama, 3);

            Console.WriteLine("\n Fibonacci dizisinin ortalaması: {0}", x);

            Console.ReadLine();
        }
    }
}
