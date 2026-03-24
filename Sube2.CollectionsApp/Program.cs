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
        }
    }

    class Test<T>
    {
        public T value1;
        public T value2;
    }
}
