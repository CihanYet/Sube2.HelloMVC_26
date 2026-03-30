using Microsoft.AspNetCore.Mvc;
using Sube2.HelloMVC.Models;
using Sube2.HelloMVC.Models.ViewModels;

namespace Sube2.HelloMVC.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {           
            var lst = new List<Ogrenci> 
            {
                new Ogrenci() { Ad = "Ali", Soyad = "Veli" },
                new Ogrenci() { Ad = "Ahmet", Soyad = "Mehmet" },
                new Ogrenci() { Ad = "Osman", Soyad = "Yılmaz" }
            };
            return View(lst);
        }

        public ViewResult OgrenciDetay()
        {
            dynamic ogr = new Ogrenci();
            ogr.Ad = "Ali";
            ogr.Soyad = "Veli";

            var ogrt = new Ogretmen();
            ogrt.Ad = "Cihan";
            ogrt.Soyad = "Yetişken";

            ViewData["Ogrenci"] = ogr;
            ViewBag.Student = ogr;

            var vm = new DetayViewModel();
            vm.Ogretmen = ogrt;
            vm.Ogrenci = ogr;

            return View("Detay", vm);
        }
    }
}
//Controllerden->View Veri Taşıma
//ViewData:Key-Value pair ile çalışan bir koleksiyondur. Birden fazla değer ViewData'lar ile tanımlanıp taşınabilir. Burada önemli nokta, birden fazla ViewData tanımlandığında, daha önce kullanılan key bir daha kullanılamaz. Keyler string, value'lar object'dir.
//ViewBag: ViewData ile aynı key-value koleksiyonunu kullanır. Bu nedenle key'ler tanımlanırken tekil olmasına dikkat edilmelidir. Dynamic bir yapıdır, içinde tutulan değerin veri tipi, Runtime sırasında çözümlenir.