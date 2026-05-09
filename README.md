# LuxeCinema 
Sinema Otomasyonu - C# Windows Forms

## Proje Hakkında 
**LuxeCinema**, bir sinema salonunun temel işlemlerini yönetmek amacıyla geliştirilmiş masaüstü otomasyon uygulamasıdır. Kullanıcılar film ve seans seçerek koltuk rezervasyonu yapabilir, büfeden ürün ekleyebilir ve 6 haneli benzersiz bilet kodlarıyla biletlerini yönetebilir.
 
Bu proje, grup olarak oluşturulan taslak ve fikirler üzerine inşa edilmiştir. Geliştirme sürecinde tespit edilen hatalar ve iyileştirmeler Claude Code ile şahsım tarafından proje bittikten sonra giderilmiştir.


## Özellikler
 
-  **Bilet Alma** — Ad soyad, telefon, film ve seans seçimi
-  **Koltuk Seçimi** — 5×10 interaktif koltuk haritası (yeşil = boş, kırmızı = dolu)
-  **Büfe Sistemi** — Patlamış mısır, kola, su seçimi ve fiyat hesaplama
-  **6 Haneli Bilet Kodu** — Her bilete özel otomatik üretilen kod
-  **Veritabanı Kaydı** — Tüm bilet bilgileri SQL Server'a kaydedilir
-  **Bilet İadesi** — 6 haneli kod ile bilet iptali
-  **Dolu Koltuk Kontrolü** — Aynı seans ve filmdeki dolu koltuklar tekrar satılamaz

##  Kullanılan Teknolojiler

- C#  / .NET  
- Windows Forms 
- SQL Server 

## Veritabanı Kurulumu
 
SQL Server Management Studio'da Filmler adında bir veritabanı oluşturun, ardından aşağıdaki sorguyu çalıştırın:
```sql
CREATE TABLE Biletler (
    BiletKod   CHAR(6)        PRIMARY KEY,
    AdSoyad    NVARCHAR(100),
    TelNo      NVARCHAR(20),
    Film       NVARCHAR(100),
    Seans      NVARCHAR(50),
    Koltuk     NVARCHAR(50),
    BufeSiparis NVARCHAR(200),
    ToplamFiyat INT
)
```


## Notlar
Bu proje **Yönetim Bilişim Sistemleri** bölümü 2. sınıf Sistem Analizi ve Tasarım ders kapsamında grup çalışması olarak geliştirilmiştir.
 
- Projenin taslağı ve fikir altyapısı grup olarak oluşturulmuştur.
- Kod geliştirme ve hata giderme sürecinde **Claude Code** yapay zeka aracından yararlanılmıştır(Proje bittikten sonra kendim değiştirmek ve düzeltmek istediğim yerleri ayarladım).
- Tespit edilen hatalar (bağlantı hataları, koltuk toggle mantığı, SQL entegrasyonu vb.) claude kod incelemesiyle düzeltilmiştir.

## Görsel
<img width="1104" height="553" alt="image" src="https://github.com/user-attachments/assets/5f126dcc-596b-4376-84ad-f2d9d64c099a" />

<img width="1034" height="522" alt="image" src="https://github.com/user-attachments/assets/7a2430e6-8dfc-484c-af07-0c9205e291bd" />

<img width="1053" height="500" alt="image" src="https://github.com/user-attachments/assets/5a71c7d8-943a-43de-95ac-3b9dd66e27d7" />


