using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bağilliste_queue
{
    internal class liste
    {
        node ilkNode = new node("");
        int verisayisi = 0;

        public liste()
        {
            this.ilkNode.sonraki = null;
            this.ilkNode.veri = null;
        }
        public void ekle(string veri)
        {
            node yeniNode = new node(veri);
            node sonNode = new node("");
            sonNode = ilkNode;
            while (sonNode.sonraki != null)
            {
                sonNode = sonNode.sonraki;
            }

            sonNode.sonraki = yeniNode;//listenin sonundaki yeni eleman
            verisayisi++;
        }

        public void sil()
        {
            if (ilkNode.sonraki != null)
            {
                ilkNode.sonraki = ilkNode.sonraki.sonraki;
                verisayisi--;
            }
            else
            {
                Console.WriteLine("bagil liste bos");
                Console.ReadLine();
            }
        }
        public void listele()
        {
            node sonNode = new node("");
            sonNode = ilkNode;
            if (sonNode.sonraki == null)
            {
                Console.WriteLine("listelenecek veri yok");
                Console.ReadLine();
            }
            else
            {
                while (sonNode.sonraki != null)
                {
                    Console.WriteLine(sonNode.sonraki.veri);
                    Console.ReadLine();
                    sonNode = sonNode.sonraki;
                }
                Console.WriteLine("toplam eleman sayisi" + verisayisi);
                Console.ReadLine();
            }
        }
    }
}
