using System;

namespace DasPro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarasi Variabel
            const int a = 2;
            const int b = 4;
            const int c = 6;
            int tambah = a + b + c;
            int kali = a * b * c;
            int kurang = a - b - c;
            int bagi = a / b / c;
            
            //Menuliskan Narasi
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("-password terdiri dari 4 angka");
            Console.WriteLine("-jika ditambahkan hasilnya "+tambah);
            Console.WriteLine("-jika dikalikan hasilnya "+kali);
            Console.WriteLine("-jika dikurangkan hasilnya "+kurang);
            Console.WriteLine("-jika dibagikan hasilnya "+bagi);
            Console.WriteLine("");
            Console.Write("Enter code : ");
       }

    }  
}