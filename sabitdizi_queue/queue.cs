using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabitdizi_queue
{
    internal class queue
    {
        static int sira = 0;
        static int verisayisi = 0;

        static int[] dizi = new int[10];



        static public void ekle(int veri)
        {
            if (verisayisi >= dizi.Length)
            {
                Console.WriteLine("kuyruk dolu");
                Console.Read();

            }
            else
            {
                dizi[sira] = veri;
                sira++;
                verisayisi++;
            }
        }
         public static void sil()
        {
            if (verisayisi <= 0)
            {
                Console.WriteLine("dizi bos");
                Console.Read();
            }
            else
            {
                verisayisi--;
                sira--;
                for (int i = 1; i < verisayisi; i++)
                {
                    dizi[i - 1] = dizi[i];
                    
                }
               
            }
        }
         public static void listele()
        {
            if (verisayisi > 0)
            {
                Console.ReadLine();
                Console.WriteLine("listedeki veri sayisi " + verisayisi);
                for (int i = 0; i < verisayisi; i++)
                {
                   
                    Console.WriteLine(dizi[i]);

                   
                }
                Console.Read();
            }
            else
            {
                Console.WriteLine("kuyruk bos");
                Console.ReadLine();
            }


        }
    }
}

