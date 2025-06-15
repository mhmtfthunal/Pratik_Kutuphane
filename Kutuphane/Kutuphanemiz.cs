using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    internal class Kutuphanemiz
    {
        public Kutuphanemiz()
        {
            Console.WriteLine("Default constructor oluşturuluyor.");
        }
        public Kutuphanemiz(string kitapadi, string yazaradi, string yazarsoyadi, int sayfasayisi, string yayinevi, DateTime kayittarihi)
        {
            KitapAdi = kitapadi;
            YazarAdi = yazaradi;
            YazarSoyadi = yazarsoyadi;
            SayfaSayisi = sayfasayisi;
            YayinEvi = yayinevi;
            KayitTarihi = kayittarihi;
        }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public int SayfaSayisi { get; set; }
        public string YayinEvi { get; set; }
        public DateTime KayitTarihi { get; set; }

        public void KutuphaneBilgisi()
        {
            Console.WriteLine(YazarAdi + "'in " + SayfaSayisi + " sayfalık, " + YayinEvi + " yayınevinden çıkan " + KitapAdi + " kitabını oluşturunuz." + " Oluşturulma Tarihi: " + KayitTarihi);
        }
    }
}
