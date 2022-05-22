using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectOne
{
    class Mainclass
    {
        public static void Main(string[] args)
        {
            int n, i;
            double t_sr, t_pr, t, t_op, k;
            string leg_pol;
            Console.WriteLine("Количество лежачих полицейских");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Время опоздания");
            t_op = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Время поездки на работу без учета лежачих полицейских");
            t_sr = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Время на преодоление лежачего полицейского");
            t_pr = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("На дороге есть лежачие полицейские?");
            leg_pol = Console.ReadLine();
            t = t_sr;
            if (leg_pol == "да")
            {

                for (i = 1; i <= n; i++)
                {
                    Console.WriteLine("введите коэффициент k");
                    k = Convert.ToDouble(Console.ReadLine());
                    t += (k - 1) * t_pr;
                }
            }
            if (t > t_op)
            { Console.WriteLine("Вы опоздаете"); }
            else
            { Console.WriteLine("Вы не опоздаете"); }
        }
    }
}