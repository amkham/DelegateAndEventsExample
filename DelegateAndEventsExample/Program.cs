using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventsExample
{
    internal class Program
    {
        static Bitcoin _bitcoin = new Bitcoin(100000);
        static Ezzer _ezzer = new Ezzer(1500000);

        static void Main(string[] args)
        {
           

            MoscowApp moscowApp = new MoscowApp(_bitcoin.Curs, _ezzer.Curs);
            VolgogradApp volgogradApp = new VolgogradApp(_bitcoin.Curs, _ezzer.Curs);

            _bitcoin.NotifyCursChange += moscowApp.addToBitcoin;
            _ezzer.NotifyCursChange += moscowApp.addToEzzer;

            _bitcoin.NotifyCursChange += volgogradApp.addToBitcoin;
            _ezzer.NotifyCursChange += volgogradApp.addToEzzer;

            CommandPanel();
           

        }


        private static void CommandPanel()
        {
            String command = "";

            while (!command.Equals("exit"))
            {
                command = Console.ReadLine();

                int num = Int32.Parse(command);

                if (num > 0)
                {
                    _bitcoin.Add(num);
                    _ezzer.Add(num);
                }

                if (num < 0)
                {
                    _bitcoin.Dicrease(num);
                    _ezzer.Dicrease(num);
                }
            }
        }

    

  
    }
}
