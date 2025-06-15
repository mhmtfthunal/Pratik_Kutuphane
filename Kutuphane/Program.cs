

using Kutuphane;

Kutuphanemiz kitap1 = new Kutuphanemiz()
{
    KitapAdi = "Birinci İsimli",
    YazarAdi = "Ahmet",
    YazarSoyadi = "Yılmaz",
    SayfaSayisi = 320,
    YayinEvi = "Alfa Yayıncılık",
    KayitTarihi = DateTime.Now,
};

Kutuphanemiz kitap2 = new Kutuphanemiz()
{
    KitapAdi = "İkinci İsimli",
    YazarAdi = "Ayşe",
    YazarSoyadi = "Karan",
    SayfaSayisi = 215,
    YayinEvi = "Beta Yayıncılık",
    KayitTarihi = DateTime.Now,
};

Kutuphanemiz kitap3 = new Kutuphanemiz()
{
    KitapAdi = "Üçüncü İsimli",
    YazarAdi = "Mehmet",
    YazarSoyadi = "Demir",
    SayfaSayisi = 450,
    YayinEvi = "Gamma Yayıncılık",
    KayitTarihi = DateTime.Now,
};

Kutuphanemiz kitap4 = new Kutuphanemiz()
{
    KitapAdi = "Dördüncü İsimli",
    YazarAdi = "Elif",
    YazarSoyadi = "Şahin",
    SayfaSayisi = 275,
    YayinEvi = "Delta Yayıncılık",
    KayitTarihi = DateTime.Now,
};

Kutuphanemiz kitap5 = new Kutuphanemiz()
{
    KitapAdi = "Beşinci İsimli",
    YazarAdi = "Selin",
    YazarSoyadi = "Yurt",
    SayfaSayisi = 198,
    YayinEvi = "Epsilon Yayıncılık",
    KayitTarihi = DateTime.Now,
};

Console.WriteLine(kitap1.YazarAdi + "'in " + kitap1.SayfaSayisi + " sayfalık, " + kitap1.YayinEvi + " yayınevinden çıkan " + kitap1.KitapAdi + " kitabını oluşturunuz." + " Oluşturulma Tarihi: " + kitap1.KayitTarihi );

Kutuphanemiz yeniKitap = new Kutuphanemiz("Altıncı Kitap","Fatih","Unal",398,"Yayınevi Bilgisi",DateTime.Now);

yeniKitap.KutuphaneBilgisi();