//Zacky Julio Putra 
//Teknik Informatika B


using System;
using System.Collections.Generic;

namespace Tebak_Kata
{
    class Program
    {
        static int kesempatan = 5;
        static string kataMisteri = "kipas";
        static List<string> ListTebakan = new List<string>{};

        static void Main(string[] args)
        {
            Intro();
            PlayGame();
            endGame();
        }
        
           static void Intro()
           {
                Console.WriteLine("Halo,kesempatan kali ini kita akan bermain tebak kata");
                Console.WriteLine("kamu punya "+kesempatan+" kesempatan untuk menebak kata misteri");
                Console.WriteLine("petunjuknya adalah kata ini merupakan alat yang bisa berputar");
                Console.WriteLine($"kata tersebut terdiri dari {kataMisteri.Length} huruf");
                Console.WriteLine("alat apakah yang dimaksud?");
                
            }

            static void PlayGame()
            {
                while(kesempatan > 0)
                {
         
                    Console.Write("\nApa huruf tebakanmu? (a-z): ");
                    string input = Console.ReadLine();
                    ListTebakan.Add(input);
                    if(cekJaw(kataMisteri,ListTebakan))
                    {
                        Console.WriteLine("\nSelamat Anda berhasil menebak kata misteri.");
                        Console.WriteLine("kata misteri hari ini adalah "+kataMisteri);
                        break;
                    }
                    else if(kataMisteri.Contains(input))
                    {
                        Console.WriteLine("\nHuruf itu ada didalam kata misteri.");
                        
                        Console.WriteLine(cekHuruf(kataMisteri,ListTebakan));
                        Console.WriteLine("\nsilahkan tebak huruf yang lain...");
                    }
                    else
                    {
                        Console.WriteLine("\nhuruf itu tidak ada didalam kata misteri.");
                        kesempatan--;
                        Console.WriteLine($"Kesempatan menjawab tinggal {kesempatan}");
                    }
                }
            }

            static bool cekJaw(string kata, List<string> List)
            {
                bool ret = false;
                for (int i = 0; i < kata.Length;i++)
                {
                    string str = Convert.ToString(kata[i]);
                    if(List.Contains(str))
                    {
                        ret = true;
                    }
                    else
                    {
                        return ret = false;
                    }
                    
                }
                return ret;
             }
            
            static string cekHuruf(string kata, List<string> List)
            {
                string ret = "";
                for (int i = 0; i < kata.Length;i++)
                {
                    string str = Convert.ToString(kata[i]);
                    if(List.Contains(str))
                    {
                        ret += str;
                    }
                    else
                    {
                        ret += "_";
                    }
                    
                }
                return ret;
             }
            
             static void endGame()
             {
                 Console.WriteLine("Permainan berakhir.");
                 Console.WriteLine("Bye...");
                 Console.ReadKey();
             }
       
    }
}