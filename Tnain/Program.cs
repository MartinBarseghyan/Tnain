using System;

namespace Tnain
{
    class Program
    {
        static void Main(string[] args)
        {
             /*int a = 11;
             int b = 20;
             int c = 31;*/


            //a b c i mec@ 21
            /* if (a > b)

                Console.WriteLine(a);
            else if (c > a)
                Console.WriteLine(c);
            else if (c > b)
                Console.WriteLine(c);*/


            // a b c i poqr@ 22
            /*if (a < b)
                Console.WriteLine(a);
            else if (a < c)
                Console.WriteLine(a);
            else if (b < c)
                Console.WriteLine(b);*/

            // havasari depqum true  23
            /* if (a == b)
                 Console.WriteLine("True" );

             else if (a==c)
                 Console.WriteLine("True");

             else if (c==b)
                 Console.WriteLine("True");
             else
                 Console.WriteLine("Folse");*/

            // achmn kargov 
            /*int[] nums = { a, b, c, };
            Array.Sort(nums);
            foreach (int num in nums) Console.WriteLine(num);*/

            //achman ev nvazman kargov

            // int[] masiv = { a, b, c };

            /* for (int i = 0; i < masiv.Length; i++)
             {
                 Console.Write(masiv[i] + " ");
             }
             Array.Sort(masiv);
             Array.Reverse(masiv);
             Console.WriteLine();

             for (int i = 0; i < masiv.Length; i++)
             {
                 Console.Write(masiv[i] + " ");
             }
             Console.Read();*/

            //zuyg kent 26
            /* if (a % 2 == 0 || b % 2== 0 || c % 2 == 0)
             {
                 Console.WriteLine(1);

             }

             else  if (b % 2 == 0)
             {
                 Console.WriteLine(1);
             }

             else if (c % 2 == 0)
             {
                 Console.WriteLine(1);
             }

             else
                 Console.WriteLine(2);
             */

            //tvabanakan progresia 27
            /*int a = 1;
              int b = 3;
              int c = 5;

              if (b - a == c - b)
              {
                  Console.WriteLine(true);
              }

              else
              {
                  Console.WriteLine(false);
              }
              */

            // erkrachapakan progresia 28
            /*  int a = 2;
              int b = 4;
              int c = 8
  ;
              if (b / a == c / b)
              {
                  Console.WriteLine(true);
              }

              else
              {
                  Console.WriteLine(false);
              }
            */

            //29 artacel mecic poqr

            /*if (a > b && a > c && b>c ) 
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }

            else if (b> a && b > c && a > c)
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.WriteLine(c);

            }
            else
            {
                Console.WriteLine(c);
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
            */

            //artacel poqric mec

           /* if (a < b && a < c && b< c)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
           */




            //cuyc tal mecaguyn 31
           int k = 5;
            int u = 15;
            int g = 45;
            int l = 135;



            /* if (k > u && k> g && k > l)
                 Console.WriteLine(k);
             else if (u > k && u > g && u > l)
                 Console.WriteLine(u);
             else if (g > k && g > u && g> l)
                 Console.WriteLine(g);
             else if (l > k && l> u && l > g )
                 Console.WriteLine(l);*/


            // cuyc tal poqraguyn 32

            /* if (k < u && k < u && k < l)
                 Console.WriteLine(k);
             else if (u < k && u < g && u < l)
                 Console.WriteLine(u);
             else if (g < k && g< u &&  g < l)
                 Console.WriteLine(g);
             else if (l < k && l < u && l< g)
                 Console.WriteLine(l);*/



            // ete tveric mek havasar e 1 true 33
            /* if (k == 1)
                 Console.WriteLine(true);
             else if (u == 1)
                 Console.WriteLine(true);
             else if (g == 1)
                 Console.WriteLine(true);
             else if (l == 1)
                 Console.WriteLine(true);
             else
                 Console.WriteLine(false);*/

            //ete 2 i gumar havasar e myus erkusin tru  34
            /*if (k + u == g + l)
                Console.WriteLine(true);
            else if (k + g == u + l)
                Console.WriteLine(true);
            else if (k + l == u + g)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);*/



            // ereq tveri gumary havasa e mekin 35

            /* if (k == u + g + l)
                 Console.WriteLine(true);
             else if (u == k + g + l)
                 Console.WriteLine(true);
             else if (g == k + u + l)
                 Console.WriteLine(true);
             else if (l == k + u + g)
                 Console.WriteLine(true);
             else
                 Console.WriteLine(false);*/



            // for (int k = 0; i <= 1000; i++)// sranov mer uzac tveri cankic karox enq hanel kenter

            // harcnel 36
            /*if (k % 2 != 0 && u % 2 != 0 && g % 2 != 0 && l % 2 != 0)

                Console.WriteLine("{0} ", 1);
            else
            Console.WriteLine(2);*/

            // tvabanakan progresia

            /* if (u - k == g - u)
                 Console.WriteLine(true);
             else
                 Console.WriteLine(false);*/


            //erkrachapakan progresia 38


            /* if (u / k == g / u )
                 Console.WriteLine(true);
             else
                 Console.WriteLine(false);*/

            // achman kargi hajordakanutyamb

            int[] masiv = { k, u, g, l };

            for (int i = 0; i < masiv.Length; i++)
            {
                Console.Write(masiv[i] + " ");
            }
            Array.Sort(masiv);
            Array.Reverse(masiv);
            Console.WriteLine();

            for (int i = 0; i < masiv.Length; i++)
            {
                Console.Write(masiv[i] + " ");
            }
            Console.Read();








        }
    }
}
