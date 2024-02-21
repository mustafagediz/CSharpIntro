// See https://aka.ms/new-console-template for more information

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Konya");
            sehirler.Add("Konya");
            sehirler.Add("Konya");
            sehirler.Add("Konya");
            sehirler.Add("Konya");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler1 = new MyList<string>();
            sehirler1.Add("Sivas");
            sehirler1.Add("Sivas");
            sehirler1.Add("Sivas");
            sehirler1.Add("Sivas");
            Console.WriteLine(sehirler1.Count);
        }
    }

    //generic ile şunu yağmış oluyorsunuz hangi tipi verirseniz add gibi parametre olarak o tipte çalışıyor.

    class MyList<T>
    {
        // Generic bir sınıf tanımlanıyor. T, çeşitli tipleri temsil eden bir generic tip parametresidir.
        T[] _array;
        T[] _tempArray;
        // _array ve _tempArray adında iki dizi tanımlanıyor. _array, listenin ana dizisini tutar. _tempArray ise geçici bir dizi.

        public MyList()
        {
            // MyList sınıfının constructor (kurucu) metodu. Yapıcı metod, sınıf bir nesne oluşturulduğunda otomatik olarak çalışır.
            _array = new T[0];
            // _array dizisi sıfır elemanlı bir generic tip dizisiyle başlatılıyor.
        }

        public void Add(T item)
        {
            // Add metodu, listeye yeni bir eleman eklemek için kullanılır. T, generic tip parametresini temsil eder.
            _tempArray = _array;
            // _array'in mevcut durumunu korumak için _array'in referansı _tempArray'e atanıyor.

            _array = new T[_array.Length + 1];
            // _array dizisi, bir eleman daha ekleyecek şekilde boyutlandırılıyor.

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
                // _tempArray'den alınan elemanlar, genişletilmiş _array'e kopyalanıyor.
            }

            _array[_array.Length - 1] = item;
            // Eklenen yeni eleman, _array'in son elemanına atanıyor.
        }

        public int Count
        {
            // Count özelliği, listenin eleman sayısını döndürür.
            get { return _array.Length; }
        }
    }

}



