using System;

namespace ResponsiPemrograman2742
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama     : Ivan Nur Ilham Syah");
            Console.WriteLine("NIM      : 19.11.2742");
            Console.WriteLine("Kelas    : 19 IF 03");

            Console.WriteLine("\n");


            Karyawan karyawan1 = new Karyawan(1911, "Ivan Nur", 3000000);
            Karyawan karyawan2 = new Karyawan(2742, "Ilham Syah", 2000000);
            Karyawan karyawan3 = new Karyawan(1519, "Paijo", -100000);


            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine(" 3. | {0} {1} \t\t | {2}\t\t |", karyawan3.NIK, karyawan3.Nama, karyawan3.GajiBulanan);

            Console.WriteLine("\n\nAsikkkkk dpt kenaikan gaji nih!!!\n");

            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.NaikGaji);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.NaikGaji);
            Console.WriteLine(" 3. | {0} {1} \t\t | {2}\t\t |", karyawan3.NIK, karyawan3.Nama, karyawan3.GajiBulanan);


            Console.ReadKey();
        }
    }

}
