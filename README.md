# MVC nedir?
- MVC , Model View Controller kelimelerinin baş harflerinden adlandırılmış bir design pattern dır.Bu tasarım desenini Microsoft bir mimari olarak benimsemiştir ve MVC framework ünü yaratmıştır.
## Mantığı ;
- Client'tan gelen request neticesinde Controller'da ki ilgili Action methoda erişilir.Bu Action method içerisinde eğer gerekli ise Model 'e gidilir ve gerekli veritabanı işlemleri yapılır , gerekli veri elde edilir ve bu veri tekrar Action methoda döner , elde edilen veri gerekli ise View a gönderilir ve orada render yapılır ve görselleştirilen (client'a döndermek istediğimiz şekile evrilen) veri Action methoda döner ve Action method son veriyi response olarak Client'a döner.
- Controller = komuta merkezimiz diyebiliriz ,gelen request çerçevesinde programımızda bu requestin response'nın olması gereken şekilde sağlanması için programı komuta etcemiz ve sonuç halini response olarak döneceğimiz katman.
- Model = Veritabanı işlemlerini yapacağımız katman.
- View = Görselleştirme yapacağımız katman.
![Ekran görüntüsü 2022-04-20 013320](https://user-images.githubusercontent.com/89224500/164104872-ac4730b3-c5ad-45f1-85c5-24a01ae82650.png)
