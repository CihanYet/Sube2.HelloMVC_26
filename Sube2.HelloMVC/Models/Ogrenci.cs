namespace Sube2.HelloMVC.Models
{
    public class Ogrenci : Object
    {
        public int OgrenciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Numara { get; set; }

        public override string ToString()
        {
            return $"Ad:{this.Ad} Soyad:{this.Soyad}";
        }
    }
}
