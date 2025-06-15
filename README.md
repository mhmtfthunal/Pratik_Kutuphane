# Pratik - Kütüphane Uygulaması

Bu örnek, C# dilinde sınıf yapıları ve constructor (yapıcı metot) kullanımını pekiştirmek amacıyla geliştirilmiştir. Kitap verilerinin tutulduğu `Kutuphanemiz` adlı bir sınıf tanımlanmış ve hem parametresiz hem de parametreli constructor kullanımıyla nesneler oluşturulmuştur.

## 🎯 Amaç

* Constructor (yapıcı metod) kullanımını öğrenmek
* Farklı yollarla nesne örneklemesi yapabilmek
* Sınıf içerisindeki bilgileri dışa aktarmak için metot tanımlayabilmek
* Nesne tabanlı programlama temelini kavramak

## 🧠 Açıklama

Kutuphanemiz sınıfı aşağıdaki özellikleri içerir:

* `KitapAdi` : Kitabın adı
* `YazarAdi` : Yazarın adı
* `YazarSoyadi` : Yazarın soyadı
* `SayfaSayisi` : Kitabın sayfa sayısı
* `YayinEvi` : Kitabın yayınevi bilgisi
* `KayitTarihi` : Kitabın kütüphaneye kayıt tarihi

### Constructor Bilgisi

* **Default Constructor**: Herhangi bir parametre almaz, "Default constructor oluşturuluyor." mesajı verir.
* **Parametreli Constructor**: Kitabın tüm bilgilerini alarak ilgili property'lere atar.

### Metot Bilgisi

* `KutuphaneBilgisi()` metodu kitap hakkında özet bilgi verir. Bu bilgi kitap adı, yazar bilgisi, sayfa sayısı, yayınevi ve kayıt tarihini içerir.

## ✅ Kazanımlar

* Parametreli ve parametresiz constructor kullanımı
* Sınıf yapısında property tanımlamaları
* Nesne üzerinden metot çağırma ve bilgiyi biçimli şekilde ekrana yazdırma
* `DateTime.Now` ile sistem zamanı alma

## 🔍 Notlar

* `KutuphaneBilgisi()` metodu sayesinde tekrar eden bilgi yazdırma işlemi sadeleşmiştir.
* Parametreli constructor sayesinde nesneler doğrudan veri ile oluşturulabilir.
* Nesne oluşturulurken hem property üzerinden değer atama hem de constructor üzerinden değer gönderme örneklendirilmiştir.
