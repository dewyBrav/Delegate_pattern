using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_pattern
{
    class Program
    {
        //Action act;
            
        static void Main(string[] args)
        {

            Action<int, string> act = Print_mess;  //делегат void, два передаваймых аргумента(параметра)
            act?.Invoke(50, "Action delegate");

            Func<int, bool> func = Add_data;   //bool - тип возвращаемого значения
            int k =  new Random().Next(0, 100);
            bool ist = func(k);
            Console.WriteLine($" {ist}  is {k.ToString()}");


            Predicate<int> isPositive = delegate (int x) { return x > 0; };  //если условие соблюдено true
            Console.WriteLine(isPositive(20));
            Console.WriteLine(isPositive(-20));

            Func<string, int> func2 = varr;
           
            int x1 = func2.Invoke("Hello");
            int x2 = func2.Invoke("Hell");

            Console.WriteLine($"x={x1}, x1={x2}");




            double sinc(double x) => x != 0.0 ? Math.Sin(x) / x : 1;

            Console.WriteLine(sinc(0.1));
            Console.WriteLine(sinc(0.0));


            Console.Read();
        }


        private static int varr(string s)
        {
            int x = s == "Hello" ? 20 : 10;
            return x;
        }
        private static void Print_mess(int x, string s)
        {
            string[] m = { "Print_mess()" };
            Console.WriteLine($"Вызвана функция {m[0]} через делегат {s} со значением: {x}");

        }

        static  bool Add_data(int x)
        {
            if (x > 10)
            {
                return true;
            }
            else return false;
        }
    }
}
