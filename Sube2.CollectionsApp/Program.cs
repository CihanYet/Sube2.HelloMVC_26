using System.Collections;

namespace Sube2.CollectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Collections
            //Non-Generic Collections: İçerisindeki verileri object tipinde tutan koleksiyonlardır.

            int sayi1 = 10, sayi2 = 30;

            var sayilar = new int[2];//Type Safe
            sayilar[0] = sayi1;
            sayilar[1] = sayi2;

            ArrayList list = new ArrayList();
            list.Add("Gazi");
            list.Add(sayi1);//Boxing
            list.Add(sayi2);
            list.Add(10);
            list.Add(20);
            list.Add(10);
            list.Add(20);
            list.Add(10);
            list.Add(20);
            list.Capacity = list.Count;
            Console.WriteLine(list.Capacity);

            Console.WriteLine((int)list[1] + (int)list[2]);//Unboxing
            Console.WriteLine(sayilar[0] + sayilar[1]);

            //Generic Collections: Type Safe Collections
            var list2 = new List<int>();
            list2.Add(sayi1);
            list2.Add(sayi2);

            Console.WriteLine(list2[0] + list2[1]);

            var t = new Test<int>();
            t.value1 = sayi1;
            t.value2 = sayi2;

            Console.WriteLine(t.value1 + t.value2);
            //.......
            //......

            var t2 = new Test<string>();
            t2.value1 = "Gazi";
            t2.value2 = "Üniversitesi";

            ITest d = new Deneme();
           // d.Denemesayi = sayi1;
            d.Yazdir("Gazi");

            d = new Deneme2();
            //d2.Deneme2sayi = 10;
            d.Yazdir("Üniversitesi");
        }
    }

    interface ITest
    {
        void Yazdir(string value);
    }

    class Deneme : ITest
    {
        public int Denemesayi { get; set; }
        public void Yazdir(string value)
        {
            Console.WriteLine(value);
        }
    }

    class Deneme2 : ITest
    {
        public int Deneme2sayi { get; set; }
        public void Yazdir(string value)
        {
            Console.WriteLine(value);
        }
    }
    //Interface'ler class'ların içinde mutlaka bulunması gereken üyeleri içerirler. Eğer bir interface bir class'ın base'ine konulduğu halde, class içerisine implement edilmezse, o zaman interface hata verir.
    //Interface'ler classlar arası bir standart oluştururlar.
    class Test<T>
    {
        public T value1;
        public T value2;
    }

    class KayitIslemleri<T>
    {
        public void Kaydet(T value)
        {
            //DB İşlemleri
        }

        //public void Kaydet(Ogretmen value)
        //{
        //    //DB İşlemleri
        //}

        //public void Kaydet(Ders value)
        //{
        //    //DB İşlemleri
        //}

        //Bu şekilde her enttity için kaydet metodu yazmak yerine, Generic yapı kullanmak, kod tekrarının ve class'a sonradan yapılan müdahalelerin önüne geçer.
    }
}
