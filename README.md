# Kütüphane Sistemi

## Uygulamanın Amacı

3 farklı user tipi olan bu projenin temel amaçları şunlardır :

- Admin her yetkiye sahiptir ve her an her şeye ulaşabilir
- Personel aylık ve haftalık raporlama, kullanıcı kitap iade takibi ve kitap ekleme gibi sistemlere ulaşır
- Üye ise sisteme kaydolur ve kullanıcı girişini yapar . Sisteme giriş yaptıktan sonra kitap ödünç almak üzere yönlendirilir ve kitabı alır

  **Kitap alabilmenin şartları**
  - 20 gün içerisinde 3 den fazla kitap almamalı
  - Seçtiği kitap eğer önceden aldığı ve geri getirdiği kitap ise (Kitabı geri getirmediyse aynı kitabı bi daha alamaz)
  - Hesabı bloke edilmemişse

  **Hesap nasıl bloke olur**
  - Sisteme ilk üye olunduğunda üyeni statüsü aktifdir 
  - Eğer 5 den fazla ceza yemişse sistem otomatik olarak hesabı bloke eder

  **Vip üye nasıl olunur**
  - 5 den fazla kitap okumuşsa ve 3 den az ceza yemişse

  **Cezalar nasıl sisteme girilir**
  - Kitabın süresi 20 günü geçmişse sistem otomatik olarak kendini her gün yeniler ve para cezasını hesaplar 
  - Ceza ödendiği takdirde fatura ödendi olur ve artık hesaplanmaz
  
  **Sisteme giriş her farklı tip kullanıcı için nasıldır**
  - Personel ve admin girişi için **Personel login** seçeneği seçimelidir
  - Üye için **Member login** seçeneği seçilmelidir

  **Raporlama nasıl yapılır**
  - Personel forma girdiğinde çeşitli kategorilerde aylık ve haftalık olmak üzere rapor alabilir


### Proje de kullanılan nuget paketleri

- EntityFramework
- FontAwesome.Sharp
- System.Data.SqlClient



