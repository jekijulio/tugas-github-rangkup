/*
zacky julio putra 2207135753
*/

using System;

namespace Daspro_3
{
    class Program
    {
        static int kesempatan = 3;
        static int level = 1;
        static bool bGameSelesai = true;
        //Main method
        static void Main(string[] args)
        {
            while(kesempatan > 0){
                Intro();

                Playgame();

                if(level > 5){
                    Console.WriteLine("Menang! Level terjawab semua");
                    break;
                }
            }
            Console.WriteLine("Permainan berakhir");
        }

        static void Intro(){
            //Intro
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server...");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
        }

        static void Playgame(){
            //Deklrasi Variable
            int kodeA;
            int kodeB;
            int kodeC;
            int jumlahKode;
            string tebakanA;
            string tebakanB;
            string tebakanC;

            int hasilTambah;
            int hasilKali;

            //Inisial Variable

            Random rng = new Random();

            kodeA = rng.Next(1,level + 1);
            kodeB = rng.Next(1,level + 1);
            kodeC = rng.Next(1,level + 1);

            jumlahKode = 3;

            //Operasi aritmatika
            hasilTambah = kodeA+kodeB+kodeC;
            hasilKali = kodeA*kodeB*kodeC;


            Console.WriteLine("Password terdiri dari "+jumlahKode+" angka");
            Console.WriteLine("jika Ditambahkan hasilnya "+hasilTambah);
            Console.WriteLine("jika Dikalikan hasilnya "+hasilKali);
            //Console.WriteLine("Code : "+kodeA+" "+kodeB+" "+kodeC+"?");

            Console.Write("Maasukkan Kode Pertama : ");
            tebakanA = Console.ReadLine();
            Console.Write("Masukkan Kode Kedua : ");
            tebakanB = Console.ReadLine();
            Console.Write("Masukkan Kode Ketiga : ");
            tebakanC = Console.ReadLine();
            Console.WriteLine("Tebakan anda "+tebakanA+" "+tebakanB+" "+tebakanC+"?");

            if(tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString()){
                Console.WriteLine("Selamat, Tebakan anda benar...\n\n");

                // tambah level
               level += 1;
               Console.WriteLine("Level " +level);
            }else{
                Console.WriteLine("sayang sekali, Tebakan anda salah...\n\n");

                // kurang kesempatan
                kesempatan = kesempatan - 1;
            }
        }
    }
}
