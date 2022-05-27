using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2_3
{
    public class Kelime
    {
        public string kelime { get; set; }
        public int sayisi { get; set; }
        public Kelime(string kelime, int sayisi)
        {
            this.kelime = kelime;
            this.sayisi = sayisi;
        }
    }
}