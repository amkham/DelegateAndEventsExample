using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventsExample
{
    internal class Program
    {
        public delegate void Del(string msg);
        public delegate void Del2(int num);

        static void Main(string[] args)
        {
            Del _delate = PrintMessage;
            /// Коммент

            Del2 _delate2 = PrintNum;

            _delate("Work");
            _delate("This is delegate method");

            DelegateParam(_delate);

            Console.ReadKey();
        }


        public static void PrintNum(int a)
        {
            Console.WriteLine(a);
        }

        public static void DelegateParam(Del del)
        {
            del("Delegate with method param");
        }

        public static void PrintMessage(String msg)
        {
            Console.WriteLine(msg);
        }
    }
}
