using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103082400044
{
    class Penjumlahan
    {
        public void JumlahTigaAngka<T>(T a, T b, T c)
        {
             dynamic angka1 = a;
             dynamic angka2 = b;
             dynamic angka3 = c;

             Console.WriteLine("NIM 103082400044");
             Console.WriteLine("Hasil: " + angka1 + " " + angka2 + " " + angka3);
        }
    }

    public class SimpleDataBase<T>
    {
        public List<T> storedData
        {
            get;
            set;
        }
        public List<DateTime> inputDates
        {
            get;
            set;
        }

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void TambahData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.UtcNow);
        }
        public void PrintData()
        {
            for (int i = 0; i < storedData.Count; i++) 
            {
                Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu {inputDates[i]}");
            }
        }
    }
    class Program
    {
        static void Main(String[] args)
        {

            Penjumlahan penjumlahan = new Penjumlahan();
            penjumlahan.JumlahTigaAngka<float>(10, 30, 82);

            Console.WriteLine("");

            SimpleDataBase<int> sdb = new SimpleDataBase<int>();

            Console.WriteLine("NIM : 103082400044");
            sdb.TambahData(10);
            sdb.TambahData(30);
            sdb.TambahData(82);

            sdb.PrintData();

        }
    }
}
