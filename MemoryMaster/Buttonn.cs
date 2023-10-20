using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MemoryMaster
{
    public class Buttonn
    {
        int count = 0;
        int podejscie = 0;
        Brush color;

        public Buttonn(int count, int podejscie, Brush color)
        {
            this.count = count;
            this.podejscie = podejscie;
            this.color = color;
        }   
        public int Count { get { return count; } }
        public Brush Brush { get { return color; } }
    }
}
