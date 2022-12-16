using System;

namespace UTS_KONVERT_MATA_UANG
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Clear();
          Console.Write("Rate USD ke Rp");
          double RateUSD = Convert.ToDouble(Console.ReadLine());
          Console.Write("Total USD");
          double JumlahUang = Convert.ToDouble(Console.ReadLine());

          double Hasil = RateUSD * JumlahUang;
          Console.WriteLine("Hasil dari Konversi : "+Hasil);
          Console.ReadLine();
        }
    }
}
