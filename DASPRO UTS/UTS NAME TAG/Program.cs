using System;

namespace uts
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("UJIAN TENGAH SEMESTER");
            Console.WriteLine("1. Tugas 1 : NameTag Mahasiswa Teknik Informatika ");
            Console.Clear();
            Console.Write("Nama         :");
            string nama = Console.ReadLine().ToUpper();
            Console.Write("NIM          :");
            string NIM = Console.ReadLine().ToUpper();
            Console.Write("Konsentrasi  :");
            string Konsentrasi = Console.ReadLine().ToUpper();
            MahasiswaBaru mhs = new MahasiswaBaru(nama, NIM, Konsentrasi);
            mhs.printNameTag();
        }
    }
    class MahasiswaBaru
    {
        string nama;
        string nim;
        string konsentrasi;

        public MahasiswaBaru(string Nama, string NIM, string Konsentrasi)
        {
            nama = Nama;
            nim = NIM;
            konsentrasi = Konsentrasi;
        }
        public void printNameTag()
        {
            Console.WriteLine();
            Console.WriteLine("|***************************|");
            Console.WriteLine("|Nama : {0,20}|",nama);
            Console.WriteLine("|NIM  : {0,20}|",nim);
            Console.WriteLine("|---------------------------|");
            Console.WriteLine("|{0,27}|",konsentrasi);
            Console.WriteLine("|***************************|");
        }
    }
}
