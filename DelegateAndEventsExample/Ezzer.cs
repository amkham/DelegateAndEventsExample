using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventsExample
{
    internal class Ezzer {

        public delegate void CursChange(int num);
        public event CursChange NotifyCursChange;
    
        private int __curs;

        public Ezzer(int curs)
        {
            __curs = curs;
        }

        public int Curs { get => __curs; set => __curs = value; }

        public void Add(int num)
        {
            __curs += num;
            NotifyCursChange.Invoke(num);
        }

        public void Dicrease(int num)
        {
            __curs -= num;
            NotifyCursChange.Invoke(num);
        }
    }
}
