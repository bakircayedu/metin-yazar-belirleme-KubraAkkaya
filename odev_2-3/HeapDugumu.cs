using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2_3
{
    public class HeapDugumu
    {
        public object Deger { get; set; }
        public Kelime value { get; set; }
        public HeapDugumu(object value)
        {
            this.Deger= value;
        }
    }
}
