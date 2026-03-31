using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103082400044
{

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
        internal class Program
        {
            static void Main(String[] args)
            {
                Penjumlahan penjumlahan = new Penjumlahan();
                penjumlahan.JumlahTigaAngka<float>(10, 30, 82);

            }
        }
    }
}
