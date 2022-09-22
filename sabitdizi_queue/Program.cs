using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabitdizi_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            queue.listele();
            queue.ekle(1);
            queue.ekle(2);
            queue.ekle(3);
            queue.ekle(1);
     

            queue.listele();
            queue.sil();
            queue.listele();

        }
    }
}
