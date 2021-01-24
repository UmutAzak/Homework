using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev
{
    class Manager : IKampanyaManager
    {
      
        public void güncelle()
        {
            Console.WriteLine("Güncelle");
        }

        public void ekle()
        {
            Console.WriteLine("Ekle");
        }

        public void sil()
        {
            Console.WriteLine("Sil");
        }
    }
}
