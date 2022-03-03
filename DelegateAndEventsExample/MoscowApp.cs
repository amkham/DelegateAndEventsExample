using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventsExample
{
    internal class MoscowApp
    {
        private int __bitcoinCurs;
        private int __ezzerCurs;

        public MoscowApp(int bitcoinCurs, int ezzerCurs)
        {
            __bitcoinCurs = bitcoinCurs;
            __ezzerCurs = ezzerCurs;
        }

        public int BitcoinCurs { get => __bitcoinCurs; set => __bitcoinCurs = value; }
        public int EzzerCurs { get => __ezzerCurs; set => __ezzerCurs = value; }

        public void addToBitcoin(int num)
        {
            __bitcoinCurs += num;
            Print($"Moscow: New curs {__bitcoinCurs}");

        }

        public void addToEzzer(int num)
        {
            __ezzerCurs += num;
            Print($"Moscow: New curs {__ezzerCurs}");
        }

        private void Print(String msg)
        {
            Console.WriteLine(msg);
        }
    }
}
