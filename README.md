# 15 Farklı Design Pattern ile Yazılım Tasarımı 

Bu proje, ***Design Pattern*** (Tasarım Deseni) üzerine yapılmış kapsamlı bir eğitim ve uygulamalar serisini içermektedir. Toplamda ***15 farklı tasarım deseni*** üzerinde çalışılan bu eğitim, yazılım geliştirme süreçlerindeki en iyi pratikleri öğrenmeyi ve gerçek dünya uygulamalarında kullanılmasını sağlamıştır.

#### PROJEDE KULLANILAN PROGRAMLAMA DİLLERİ, KÜTÜPHANELER VE TEKNOLOJİLER 💻🔧
<p>
  <img alt="C#" src="https://img.shields.io/badge/C%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white&logoWidth=50" />
  <img alt="ASP.NET Core" src="https://img.shields.io/badge/ASP.NET%20Core-%231BA3E8.svg?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img alt="MVC" src="https://img.shields.io/badge/MVC-%23DD0031.svg?style=for-the-badge&logo=generic&logoColor=white" />
  <img alt="Entity Framework" src="https://img.shields.io/badge/Entity%20Framework-%2358B9C9.svg?style=for-the-badge&logo=generic&logoColor=white" />
  <img alt="MSSQL" src="https://img.shields.io/badge/MSSQL-%23B22222.svg?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" />
</p>

## 🌕 PROJE 1 - BANKA YÖNLENDİRME UYGULAMASI: CHAIN OF RESPONSIBILITY DESIGN PATTERN

Bu proje, ***Chain of Responsibility*** tasarım desenini kullanarak geliştirilmiş bir banka yönlendirme uygulamasıdır. Uygulama, müşteri işlemleri için farklı onay seviyelerine sahip bir yönlendirme sistemini simüle etmektedir. 

Projede, farklı onay seviyelerine sahip dört ana sınıf yer almaktadır: **Veznedar**, **Şube Müdür Yardımcısı**, **Şube Müdürü** ve **Bölge Direktörü**. Bu sınıflar, müşteri taleplerini uygun onay seviyelerine yönlendirir ve işlemleri gerçekleştirir. 

- **Veznedar**: Müşterinin taleplerini ilk olarak karşılayan ve onaylayan ilk seviyedir.
- **Şube Müdür Yardımcısı**: Veznedarın onay limitini aşan talepleri devralır ve onaylar.
- **Şube Müdürü**: Şube müdür yardımcısının onay limitini aşan talepleri yönetir.
- **Bölge Direktörü**: Şube müdürünün onay limitini aşan talepleri devralan en üst seviyedir.

Her bir sınıf, işlemi işleyebilecek kapasitedeyse işlemi gerçekleştirir, eğer işlemi gerçekleştiremiyorsa, bir sonraki onay seviyesine yönlendirir. Bu şekilde, iş akışı düzenli ve esnek bir şekilde yönetilir.

- [Banka Yönetim Ekranı](https://github.com/user-attachments/assets/53c7fd61-c00b-40ee-8fee-4fc30688bc52)
-----------------------------------------------------------------------
## 🌕 PROJE 2 - ÜRÜN YÖNETİM SİSTEMİ: CQRS DESIGN PATTERN

Bu proje, ***CQRS (Command Query Responsibility Segregation)*** tasarım desenini kullanarak geliştirilmiş bir ürün yönetim sistemidir. Uygulama, ürün işlemleri için **Komut (Command)** ve **Sorgu (Query)** olmak üzere iki ana sorumluluk alanına ayrılmış bir iş akışını simüle etmektedir.

Projede, ürün yönetimi için farklı işlemleri yöneten beş temel işlem bulunmaktadır: **Ürün Ekleme**, **Ürün Güncelleme**, **Ürün Silme**, **Ürün Listeleme** ve **Ürün Detay Görüntüleme**. Bu işlemler CQRS tasarım deseni ile ayrı sorumluluk alanlarına ayrılmıştır.

- **Ürün Ekleme (Command)**: Sisteme yeni bir ürün eklemek için kullanılır.
- **Ürün Güncelleme (Command)**: Mevcut bir ürün bilgisini güncellemek için kullanılır.
- **Ürün Silme (Command)**: Belirli bir ürünü sistemden kaldırmak için kullanılır.
- **Ürün Listeleme (Query)**: Sistemde bulunan tüm ürünleri listelemek için kullanılır.
- **Ürün Detay Görüntüleme (Query)**: Belirli bir ürünün detaylarını görmek için kullanılır.

Her bir sınıf, işlemi kendi sorumluluk alanına uygun şekilde ele alır. **Command** sınıfları, sistemi değiştiren işlemleri işlerken, **Query** sınıfları yalnızca veri okuma işlemlerini gerçekleştirir. Bu ayrım sayesinde, iş akışı düzenli ve esnek bir şekilde yönetilir, uygulamanın performansı ve sürdürülebilirliği artırılır. Sistemde her işlem, yalnızca kendi belirlenen sorumluluğunu yerine getirerek bakım kolaylığı ve ölçeklenebilirlik sağlar.

- [Ürün Yönetim Sistemi](https://github.com/user-attachments/assets/8e9e7502-ca90-4f1b-9306-668a49397a99)

-----------------------------------------------------------------------

## 🌕 PROJE 3 - NETFLIX ÜYELİK PAKETİ YÖNETME EKRANI: TEMPLATE METHOD DESIGN PATTERN

Bu proje, ***Template Method Design Pattern*** kullanılarak geliştirilmiş bir Netflix üyelik paketi yönetme ekranıdır. Uygulama, üyelik planlarının özelliklerini dinamik olarak yönetmek ve görüntülemek için esnek bir yapı sunar.

Template Method Design Pattern, üyelik planları için ortak bir iş akışını temel sınıfta tanımlar. Alt sınıflar bu iş akışını özelleştirerek farklı plan türlerini destekler. Uygulamanın temelinde, üyelik planlarının ortak işlemlerini barındıran **NetflixPlans** isimli bir temel sınıf yer almaktadır. Bu temel sınıf, tüm plan türleri için ortak bir iş akışını tanımlar. Plan türleri, **BasicPlans**, **StandartPlans** ve **UltraPlans** isimli alt sınıflar aracılığıyla temsil edilir.

- **Temel Sınıf (NetflixPlans):** Üyelik planlarının ortak işlemlerini barındırır.  
- **Alt Sınıflar:**  
  - **BasicPlans:** Temel Plan özelliklerini içerir.  
  - **StandartPlans:** Standart Plan özelliklerini içerir.  
  - **UltraPlans:** Ultra Plan özelliklerini içerir.
    
 Her bir alt sınıf, temel sınıfın sunduğu şablon yöntemlerini özelleştirerek farklı planların özelliklerini belirler ve yönetir. Bu yapı sayesinde, uygulama hem esneklik hem de genişletilebilirlik sağlar.
 
- [Netflix Üyelik Paketi Yönetme Ekranı](https://github.com/user-attachments/assets/76c6589c-eb3b-460c-9a0d-e4a07f58293b)

-----------------------------------------------------------------------

#### 📦 Veri Tabanı Yedek Dosyaları

Bu proje serisine ait tüm veri tabanı yedek dosyalarını aşağıdaki bağlantıdan toplu halde indirebilirsiniz. Yedek dosyaları, projeleri incelemeniz ve yerel ortamınızda çalıştırabilmeniz için gerekli tüm veritabanı tablolarını ve verilerini içermektedir.

[**Veri Tabanı Yedek Dosyalarını İndir (ZIP)**](https://drive.google.com/file/d/19i26qy_iTlNNk7_-jTYTxd22AYsn9sDx/view?usp=sharing)

-----------------------------------------------------------------------

Görüşürüz 🎉
