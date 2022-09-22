using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bağilliste_queue
{
   
        internal class node
        {
            public string veri;
            public node sonraki;


            public node(string veri)
            {
                this.veri = veri;
                this.sonraki = null;

            }


        
    }
}
