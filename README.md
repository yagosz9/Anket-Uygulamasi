# AnketLab - Anket Yönetim Sistemi

AnketLab, C# Windows Forms ve MySQL kullanılarak geliştirilmiş masaüstü tabanlı bir anket yönetim sistemidir. Bu proje, Doğuş Üniversitesi Meslek Yüksekokulu Web Tasarımı ve Kodlama programı Görsel Programlama dersi kapsamında hazırlanmıştır.

Sistem; admin kullanıcıların anket oluşturmasını, kategorileri yönetmesini, anket sonuçlarını incelemesini ve normal kullanıcıların anketlere katılarak kendi cevaplarını görüntülemesini sağlar.

---

## Projenin Amacı

AnketLab projesinin temel amacı, anket oluşturma ve cevaplama sürecini daha düzenli, kolay ve anlaşılır hale getirmektir.

Günümüzde eğitim kurumları, sosyal etkinlikler, spor organizasyonları ve farklı kurumlar geri bildirim toplamak için anket sistemlerine ihtiyaç duymaktadır. Bu proje de bu ihtiyaca yönelik olarak geliştirilmiştir.

AnketLab sayesinde:

- Admin kullanıcılar kolayca anket oluşturabilir.
- Anketler kategoriye göre düzenlenebilir.
- Kullanıcılar sistemdeki anketlere hızlıca katılabilir.
- Verilen cevaplar veritabanında saklanabilir.
- Sonuçlar daha düzenli şekilde görüntülenebilir.
- Aynı kullanıcının aynı ankete tekrar cevap vermesi engellenebilir.

---

## Sistem Ne İşe Yarar?

AnketLab, kullanıcı görüşlerini toplamak ve bu görüşleri düzenli şekilde saklamak için kullanılan bir sistemdir.

Örneğin bu sistem:

- Bir okulda ders memnuniyet anketi yapmak,
- Bir etkinlik için katılım durumu öğrenmek,
- Spor turnuvası için öğrenci görüşü toplamak,
- Sosyal etkinliklerle ilgili geri bildirim almak,
- Teknoloji kullanımıyla ilgili kullanıcı tercihlerini öğrenmek

amacıyla kullanılabilir.

Sistem hem yönetici hem de kullanıcı tarafını içerdiği için gerçek bir anket yönetim sürecini temel düzeyde karşılamaktadır.

---

## Neden Bu Proje Yapıldı?

Bu proje, hem görsel programlama mantığını uygulamak hem de gerçek hayatta kullanılabilecek bir masaüstü yazılım geliştirmek amacıyla yapılmıştır.

Projenin yapılma nedenleri şunlardır:

- Windows Forms ile çoklu form yapısını öğrenmek
- MySQL veritabanı ile bağlantı kurmak
- CRUD işlemlerini uygulamak
- Admin ve kullanıcı rolleri arasında yetki ayrımı yapmak
- Kullanıcı dostu bir arayüz tasarlamak
- Veritabanına kayıt ekleme, listeleme, güncelleme ve silme işlemlerini gerçekleştirmek
- Gerçek hayatta kullanılabilecek bir geri bildirim sistemi geliştirmek

Bu proje sayesinde hem arayüz tasarımı hem de veritabanı bağlantılı uygulama geliştirme süreci uygulanmıştır.

---

## Kullanılan Teknolojiler

Projede aşağıdaki teknolojiler kullanılmıştır:

| Teknoloji | Kullanım Amacı |
|---|---|
| C# | Uygulamanın kodlanması |
| Windows Forms | Masaüstü arayüz tasarımı |
| .NET 8.0 | Uygulama altyapısı |
| Visual Studio 2022 | Geliştirme ortamı |
| MySQL | Veritabanı yönetimi |
| phpMyAdmin | Veritabanı tablolarını yönetme |
| MySql.Data | C# ile MySQL bağlantısı kurma |

---

## Sistem Nasıl Geliştirildi?

Proje çoklu form yapısı ile geliştirilmiştir. Her form belirli bir göreve ayrılmıştır.

Örneğin:

- `FormLogin` kullanıcı girişini yapar.
- `FormAdminDashboard` admin ana panelini gösterir.
- `FormUserDashboard` normal kullanıcı panelini gösterir.
- `FormAnketOlustur` yeni anket oluşturmayı sağlar.
- `FormAnketListele` anketleri listeleme, güncelleme ve silme işlemlerini yapar.
- `FormAnketCoz` kullanıcının anket cevaplamasını sağlar.
- `FormSonuclar` adminin anket sonuçlarını görmesini sağlar.
- `FormSonuclarim` kullanıcının kendi cevaplarını görmesini sağlar.
- `FormKategoriler` kategori ekleme, güncelleme ve silme işlemlerini yapar.

Veritabanı işlemlerinde MySQL kullanılmıştır. C# tarafında `MySqlConnection`, `MySqlCommand`, `MySqlDataReader` ve `MySqlDataAdapter` yapılarıyla veritabanına bağlanılmıştır.

Kayıt işlemlerinde hata riskini azaltmak için `try-catch` blokları kullanılmıştır. Bazı işlemlerde veri tutarlılığını korumak için transaction yapısından yararlanılmıştır.

---

## Veritabanı Yapısı

Proje `anketlabdb` adlı MySQL veritabanı ile çalışmaktadır.

Temel tablolar:

| Tablo | Görevi |
|---|---|
| `kullanicilar` | Kullanıcı adı, şifre ve rol bilgilerini tutar |
| `kategoriler` | Anket kategorilerini saklar |
| `anketler` | Oluşturulan anketleri tutar |
| `sorular` | Anketlere ait soruları saklar |
| `secenekler` | Sorulara ait cevap seçeneklerini saklar |
| `cevaplar` | Kullanıcıların verdiği cevapları saklar |

Veritabanı yedeği proje içerisinde `anketlabdb.sql` dosyası olarak yer almaktadır.

---

## Admin Paneli Ne Yapar?

Admin kullanıcı sistemin yönetici tarafıdır.

Admin panelinde yapılabilen işlemler:

- Sistemdeki toplam anket sayısını görüntüleme
- Toplam kullanıcı sayısını görüntüleme
- Aktif kategori sayısını görüntüleme
- Bugünkü cevap sayısını görüntüleme
- Anket oluşturma
- Kategoriye göre otomatik cevap seçenekleri oluşturma
- Anketleri listeleme
- Anket güncelleme
- Anket silme
- Kategori ekleme, güncelleme ve silme
- Anket sonuçlarını görüntüleme
- Son oluşturulan anketleri takip etme
- Kategori dağılımı ve katılım istatistiklerini görme

---

## Kullanıcı Paneli Ne Yapar?

Normal kullanıcı sistemin anketlere katılan tarafıdır.

Kullanıcı panelinde yapılabilen işlemler:

- Sistemdeki anketleri görüntüleme
- Anket seçip cevaplama
- Daha önce cevapladığı ankete tekrar cevap verememe
- Kendi verdiği cevapları görüntüleme
- Toplam anket, cevaplanan anket ve bekleyen anket sayılarını görme

Bu yapı sayesinde kullanıcı sadece kendisine ait işlemleri yapabilir.

---

## Rol Tabanlı Yetkilendirme

Sistemde iki temel rol vardır:

| Rol | Açıklama |
|---|---|
| Admin | Sistemi yönetir, anket ve kategori işlemlerini yapar |
| Kullanıcı | Anketleri görüntüler, cevaplar ve kendi sonuçlarını görür |

Kullanıcı giriş yaptıktan sonra rol bilgisine göre ilgili panele yönlendirilir.

---

## Öne Çıkan Özellikler

- Modern ve sade arayüz
- Mor-beyaz tema
- Admin ve kullanıcı ayrımı
- MySQL veritabanı bağlantısı
- Anket oluşturma
- Kategori yönetimi
- Anket listeleme, güncelleme ve silme
- Kullanıcı anket cevaplama
- Aynı ankete tekrar cevap vermeyi engelleme
- Sonuçları görüntüleme
- Dashboard istatistikleri
- Kategoriye göre otomatik cevap seçenekleri

---

## Veritabanı Kurulumu

Projeyi çalıştırmadan önce veritabanı kurulmalıdır.

1. XAMPP açılır.
2. Apache ve MySQL başlatılır.
3. Tarayıcıdan phpMyAdmin açılır:

## MySQL Port Bilgisi

Proje MySQL veritabanı ile çalışmaktadır. MySQL portu bilgisayara göre değişebilir.

Geliştirme ortamında kullanılan bağlantı örneği:

```csharp
server=localhost;port=3307;database=anketlabdb;uid=root;pwd=;

```text
localhost/phpmyadmin

