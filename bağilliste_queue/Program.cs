using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bağilliste_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bliste = new bliste();
            bliste.listele();
            bliste.ekle("ö");
            bliste.ekle("ö");
            bliste.ekle("z");
            bliste.ekle("e");
            bliste.ekle("y");
            bliste.listele();
            bliste.sil();
            bliste.listele();
            bliste.ekle("d");
            bliste.listele();
        }
    }
}
