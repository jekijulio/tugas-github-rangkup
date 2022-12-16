using System;
using System.Text.RegularExpressions;

namespace UTSENKRIPSI
{
    class program
    {
        public static void Main(string[] args) {
            String kata, enkripsi = "";
            String hurufalfabet = "abcdefghijklmnopqrstuvwxyzabcABCDEFGHIJKLMNOPQRSTUVWXYZABC";
            Regex rgx = new Regex("[^a-z,A-Z ]");
            do
            {
                Console.Write("KATA : ");
                kata = Console.ReadLine();
            } while (String.IsNullOrEmpty(kata) || rgx.IsMatch(kata));

            foreach (Char t in kata)
            {
                Char enkrip = ' ';
                for (int i = 0; i < hurufalfabet.Length; i++)
                {
                    Char c = hurufalfabet[i];
                    if (t.Equals(c)) {
                        enkrip = hurufalfabet[i+3];
                        break;
                    } else if (t.Equals(' ')) {
                        enkrip = ' '; 
                        break;
                    }
                }
                enkripsi = enkripsi + enkrip;
            }
            Console.WriteLine("Hasil Enkripsi : " + enkripsi); 
        }
    }
}