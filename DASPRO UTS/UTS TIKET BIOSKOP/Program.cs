using System;

namespace UTS_TIKET_BIOSKOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama : ");
            string nama = Console.ReadLine();
            Console.WriteLine("Tahun Kelahiran : ");
            int tahunKelahiran = Convert.ToInt32(Console.ReadLine());
            printKarcis (nama,tahunKelahiran);
        }
        public static void hitungHargaKarcis(int tahunKelahiran)
        {
            int harga;
            if((2022 - Convert.ToInt32 (tahunKelahiran)) < 10 || (2022 - Convert.ToInt32 (tahunKelahiran) > 60)){
                harga = 10000;
                Console.WriteLine (" |Harga :                                Rp. "+harga+"|");
            } else if ((2022 - Convert.ToInt32 ( tahunKelahiran)) > 10 || (2022 - Convert.ToInt32 (tahunKelahiran) < 60)){
                harga = 25000;
                Console.WriteLine(" |Harga :                                 Rp. " + harga +"|");
            }
        }
        public static void printKarcis (string nama, int tahunKelahiran)
        {
         Console.WriteLine(" |=================================================|");
         Console.WriteLine(" |******************STUDIO 1***********************|");
         Console.WriteLine(" |Nama  :           {0,31}|", nama);
         hitungHargaKarcis(tahunKelahiran);
         Console.WriteLine(" |=================================================|");
        }
    }
}
