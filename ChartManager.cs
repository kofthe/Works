using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ChartManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendi" + product.Adi);

        }

        public void Ekle2(string urunAdi, string Aciklama, double fiyat, int stokAdedi) 
        { 

            Console.WriteLine("Sepete Eklendi" + urunAdi ) ;

        }


       

        
    }
}
