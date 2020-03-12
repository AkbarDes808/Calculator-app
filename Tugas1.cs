using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator sederhana");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("");
            Console.WriteLine("Pilih menu perhitungan(1,2,3,4) :");
            {
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Masukkan angka pertama:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Masukkan Angka kedua:");
                int c = Convert.ToInt32(Console.ReadLine());
                {
                    if (a == 1)
                    {
                        int penjumlahan = b + c;
                        Console.WriteLine($"Maka hasil penjumlahan = {penjumlahan}");
                    }
                    else if (a == 2)
                    {
                        int pengurangan = b - c;
                        Console.WriteLine($"Maka Hasil Pengurangan = {pengurangan}");
                    }
                    else if (a == 3)
                    {
                        int perkalian = b * c;
                        Console.WriteLine($"Maka Hasil Perkalian = {perkalian}");
                    }
                    else if (a == 4)
                    {
                        int pembagian = b / c;
                        Console.WriteLine($"Maka Hasil Pembagian = {pembagian}");
                    }
                }
            }
        }
    }
}
