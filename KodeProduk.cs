using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL4
{
    class KodeProduk
    {
        private Dictionary<string, String> dataKodeProduk;

        public KodeProduk()
        {
            dataKodeProduk = new Dictionary<string, String>
            {
                {"Laptop", "E100"},
                {"Smarthphone", "E101"},
                {"Tablet", "E102"},
                {"Headset", "E103"},
                {"Keyboard", "E104"},
                {"Mouse", "E105"},
                {"Printer", "E106"},
                {"Monitor", "E107"},
                {"Smartwatch", "E108"},
                {"Kamera", "E109"}
            };
        }

        public String GetKodeProduk(string ProductCode)
        {
            if (dataKodeProduk.ContainsKey(ProductCode))
            {
                return dataKodeProduk[ProductCode];
            }
            else
            {
                return "-1";
            }
        }
    }
}
