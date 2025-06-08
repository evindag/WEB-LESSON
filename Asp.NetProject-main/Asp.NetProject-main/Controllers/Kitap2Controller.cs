using Microsoft.AspNetCore.Mvc;
public class Kitap2Controller : Controller
{
 public string Index2()
 {
 return "Kitap controller sınıfındaki Index metodu çalıştı";
 }

 public FileResult Resim()
 {
 return File("~/meb.png", "image/png");
 }
  [Route("Kitap2/Liste/{id}/{ad}")]
 public string Liste(int id, string ad)
 {
 return $"Parametreden gelen id={id}, ad={ad}";
 }
}
