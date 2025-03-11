
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL4
{
    class KodeProdukMain
    {
        static void Main()
        {
            KodeProduk kodeProduk = new KodeProduk();

            Console.Write("Masukkan nama produk: ");
            string Product = Console.ReadLine();

            String kode = kodeProduk.GetKodeProduk(Product);

            if (kode != "-1")
            {
                Console.WriteLine($"Kode produk untuk {Product} adalah {kode}");
            }
            else
            {
                Console.WriteLine("Produk tidak ditemukan");
            }
        }
    }
}