# Assignment-1
Konu: Spiral Roll benzeri oyun gameplay yapımı.

İçerik: Spiral Roll oyununa benzer, tema olarak kış teması seçilmiş ve spiral ağaç objesi yerine kartopu kullanılarak benzer oynanışta geliştirilmiş oyun.

Oynanış ve Kurallar

1- Spiral Roll oyunu ile aynı şekilde ekrana basılı tutarak kartopu oluşturulur ve bırakıldığıda bellirli bir kuvvet ile (Fizik Motoru kullanılarak) oluşan kartopu ileri doğru atılır. Kullanılan kuvvet objenin kütlesini dikkate almaktadır ve kolayca kuvvet değerleri editör üzerinde değiştirilebilir veya değiştirilebilir hale getirilebilir.

2- Spiral Roll oyununa benzer şekilde oyunda karşımıza çıkan engelleri bu oyunda kartopları ile vurarak bertaraf edebiliriz. Bertaraf edilmeyen engellere Oyuncu'nun (Kürek) temas etmesi üzerine mevcut bölüm yeniden başlar. Bazı engelleri vurmak ağaç dalı vs. sabit kırılamayan engeller ile zorlaştırılmıştır.

3- Spiral Roll oyununda bulunan ve engel teşkil eden metal ve bıçaklar yerine hediye paketleri kullanılmıştır. Bu hediye paketlerinin üzerinden kar küremediği zaman sorunsuz geçebilen oyuncu, hediye peketlerinin bulunduğu yerlerde kar küremeye çalışırsa bölüm yeniden başlar.

4- Spiral Roll oyununa benzer şekilde final bölümü için ayrı bir platform oluşturulmuş bu platformdan fırlatılan obje denk getirilen kutuların üzerinde yazan puanı oyuncuya kazandırır ve hanesine ekler. Bu bölümde sadece bir obje oluşturulabilir ve son obje oluşturulup fırlatıldıktan 5 saniye sonra kazanılan puanlar sonraki seviyeye aktarılır yeni bölüme geçilir.

5- Puanlama sistemi benzer şekilde oluşturulmuştur. Oyuncu ne kadar büyük bir kartopu oluşturursa saniyede kazandığı puanlar katlanarak artar. Final bölümünde vurulan kutuların puanları haneye eklenir. Hedeflerin verdiği puanlar kolay bir şekilde editörden değiştirilebilmektedir.


Notlar:
Oyunun bütün bölümleri değil örnek teşkil edecek 3 adet bölüm tasarlanmıştır. Şuan menüden başlayan oyun sıralı olarak bölümleri size oynatır. Sistem ileride ana menüde bölüm seçilebilecek ve seçilen bölümden başlatılacak şekilde tasarlanmıştır fakat o özelliği gameplay'e dahil olmadığını düşündüğüm için henüz eklemedim. Oyundaki scriplerin neredeyse tamamı tarafımdan kodlanmıştır. Şuan için kodların optimizasyon sıkıntısı yaratabileceğinin farkındayım. Zamandan kazanmak için optimizasyonda sıkıntı yaratabilecek kısımlar üzerinde fazlaca durmadım. Kullanılan hazır assetler ise /Sources klasörü altında bulunmaktadır.

