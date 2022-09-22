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
            var liste = new liste();
            liste.listele();
            
            liste.ekle("e");
            liste.ekle("y");
            liste.listele();
            liste.sil();
            liste.listele();
            liste.ekle("d");
            liste.listele();
        }
    }
}
