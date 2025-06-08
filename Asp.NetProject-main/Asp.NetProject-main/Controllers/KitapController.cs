using Microsoft.AspNetCore.Mvc;
public class KitapController: Controller 
//Yukarıdaki satır KitapController sınıfının Controller adlı temel sınıftan miras aldığını (kalıtım) gösterir.
{
 public ActionResult Index() //Index: Metota verilen isimdir.
 //ActionResult, bir action'ın sonucunu temsil eden soyut bir sınıftır. 
 //Bu, bir view döndürmeyi, bir JSON veri döndürmeyi, bir başka action'a yönlendirmeyi veya HTTP durum kodları gibi çeşitli sonuçları içerebilir.
 {
 return View(); //Gönderilen isteğe karşılık olarak bir view (kullanıcı arayüzü) oluşturup tarayıcıya göndermek için kullanılır.
 }
  public JsonResult JsonCikti()
 {
 return Json(new
 {
 Id = 1,
 Seviye = "11. Sınıf",
 KitapAdi = "WEB TABANLI UYGULAMA GELİŞTİRME"
 });
 }
}