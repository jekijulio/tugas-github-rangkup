using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            int kesalahan = 0; 
            String jawaban = ""; 
            bool salah = false, menang = false, kalah = false, benar = false; 
            Console.Clear(); 
            string[] soal = new string[10]; 
            soal[0] = "raffiahmad";
            soal[1] = "nagitaslavina";
            soal[2] = "irwansyah";
            soal[3] = "dennycagur";
            soal[4] = "andretaulany";
            soal[5] = "andhikapratama";
            soal[6] = "suryainsomnia";
            soal[7] = "agnesmonica";
            soal[8] = "baimwong";
            soal[9] = "atta";
            Random randGen = new Random();
            var random = randGen.Next(0, 9); 
            string soalGame = soal[random];
            char[] guess = new char[soalGame.Length]; 

            for (int p = 0; p < soalGame.Length; p++) { 
                guess[p] = '_'; 
            }
 
            while (menang == false && kalah == false) 
            {
                Console.Write("silahkan tebak hurufnya : ");
                char playerGuess = char.Parse(Console.ReadLine()); 
                for (int j = 0; j < soalGame.Length; j++) 
                {
                    if (playerGuess == soalGame[j]) { 
                        benar = true; 
                        guess[j] = playerGuess; 
                    } else if (j == soalGame.Length - 1 && benar == false){ 
                        salah = true; 
                    }
                }
                Console.Clear();
                jawaban = new String(guess); 
                if (salah == true) {
                    Console.WriteLine("Tebakan anda salah!"); 
                    kesalahan++; 
                    salah = false; 
                }
                benar = false; 
                Console.WriteLine(guess); 
                Console.WriteLine();
                switch (kesalahan) 
                {
                    case 1: 
                        Console.WriteLine("_||_");
                        break;
                    case 2: 
                        Console.WriteLine(" ||");
                        Console.WriteLine(" ||");
                        Console.WriteLine(" ||");
                        Console.WriteLine(" ||");
                        Console.WriteLine("_||_");
                        break;
                    case 3: 
                        Console.WriteLine(" ||/");
                        Console.WriteLine(" ||");
                        Console.WriteLine(" ||");
                        Console.WriteLine(" ||");
                        Console.WriteLine(" ||");
                        Console.WriteLine("_||_");
                        break;
                    case 4:
                        Console.WriteLine("____");
                        Console.WriteLine(" ||/");
                        Console.WriteLine(" ||");
                        Console.WriteLine(" ||");
                        Console.WriteLine(" ||");
                        Console.WriteLine(" ||");
                        Console.WriteLine("_||_");
                        break;
                    case 5:
                        Console.WriteLine("_________");
                        Console.WriteLine(" ||/    |");
                        Console.WriteLine(" ||");
                        Console.WriteLine(" ||");
                        Console.WriteLine(" ||");
                        Console.WriteLine(" ||");
                        Console.WriteLine("_||_");
                        break;
                    case 6:
                        Console.WriteLine("_________");
                        Console.WriteLine(" ||/    |");
                        Console.WriteLine(" ||    (_)");
                        Console.WriteLine(" ||");
                        Console.WriteLine(" ||");
                        Console.WriteLine(" ||");
                        Console.WriteLine("_||_");
                        break;
                    case 7:
                        Console.WriteLine("_________");
                        Console.WriteLine(" ||/    |");
                        Console.WriteLine(" ||    (_)");
                        Console.WriteLine(" ||    \\|/");
                        Console.WriteLine(" ||");
                        Console.WriteLine(" ||");
                        Console.WriteLine("_||_");
                        break;
                    case 8:
                        Console.WriteLine("_________");
                        Console.WriteLine(" ||/    |");
                        Console.WriteLine(" ||    (_)");
                        Console.WriteLine(" ||    \\|/");
                        Console.WriteLine(" ||     |");
                        Console.WriteLine(" ||");
                        Console.WriteLine("_||_");
                        break;
                    case 9:
                        Console.WriteLine("_________");
                        Console.WriteLine(" ||/    |");
                        Console.WriteLine(" ||    (_)");
                        Console.WriteLine(" ||    \\|/");
                        Console.WriteLine(" ||     |");
                        Console.WriteLine(" ||    / \\");
                        Console.WriteLine("_||_");
                        break;
                    case 10:
                        Console.WriteLine("____");
                        Console.WriteLine(" ||/      |");
                        Console.WriteLine(" ||      (_)");
                        Console.WriteLine(" ||      \\|/");
                        Console.WriteLine(" ||       |");
                        Console.WriteLine(" ||      / \\");
                        Console.WriteLine("_||_");
                        break;

                    default:
                        break;
                }

                if (jawaban == soalGame) { 
                    Console.WriteLine("Selamat, anda menang!"); 
                    menang = true; 
                } else if (kesalahan == 10 && jawaban != soalGame) { 
                    Console.WriteLine("Anda kurang beruntung!"); 
                    kalah = true;
                }
            }
        }
    }
}