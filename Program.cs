using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_sinifi_methodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            // sort
            int[] sayiDizisi = { 21, 12, 4, 86, 73, 3, 11, 17 };
            Console.WriteLine("****Sırasız Liste****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("****Sıralı Liste****");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            // clear

            Console.WriteLine("****Clear****");
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            // reverse
            Console.WriteLine("****Reverse****");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            // indexof
            Console.WriteLine("****İndexOf****");

            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));
            // resize

            Console.WriteLine("****Resize****");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.ReadLine();
        }
        
    }
}
