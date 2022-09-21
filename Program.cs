using System;
namespace CalculatorApp {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metode Calculator Yang Akan Digunakan");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian \n\nSilahkan Input Metode Yang Digunakan\t:");
            int metode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Angka Pertama\t: ");
            int angka1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Angka Kedua\t: ");
            int angka2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            // Switch Case Untuk Metode
            switch (metode)
            {
                case 1:
                {
                    result =  Penjumlahan(angka1, angka2);
                    break;
                }
                case 2:
                {
                    result =  Pengurangan(angka1, angka2);
                    break;
                }
                case 3:
                {
                    result =  Perkalian(angka1, angka2);
                    break;
                }
                case 4:
                {
                    result =  Pembagian(angka1, angka2);
                    break;
                }
                default:
                {
                    Console.WriteLine("Metode Yang Anda Masukkan Salah");
                    break;
                }
            }
            Console.WriteLine("Hasilnya adalah {0}", result);
            Console.ReadKey();
        }

        // Metode Penjumlahan
        public static int Penjumlahan(int angka1, int angka2)
        {
            int hasil = angka1 + angka2;
            return hasil;
        }

        // Metode Pengurangan
        public static int Pengurangan(int angka1, int angka2)
        {
            int hasil = angka1 - angka2;
            return hasil;
        }

        // Metode Perkalian
        public static int Perkalian(int angka1, int angka2)
        {
            int hasil = angka1 * angka2;
            return hasil;
        }

        // Metode Pembagian
        public static int Pembagian(int angka1, int angka2)
        {
            int hasil = angka1 / angka2;
            return hasil;
        }
    }
}