using System;

namespace ARRAY
{
    class Program
    {
        static char[,] tank = {
            {' ','1','2','3','4'},
            {'1','~','~','~','~'},
            {'2','~','~','~','~'},
            {'3','~','~','~','~'},
            {'4','~','~','~','~'}
        };
        static int[,] ans = {
            {1,1},
            {2,4},
            {3,2}
        };
        static int[,] recent = {
            {0,0},
            {0,0},
            {0,0}
        };
        static int[] tebakan = {0,0};
        static int jB = 0;
        static bool gstate = true;
        static int truth = 0;

        static void Main(string[] args)
        {
            while(gstate)
            {
                drawTank();
                try
                {
                    Console.Write("tebak baris: "); tebakan[0] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("tebak kolom: "); tebakan[1] = Convert.ToInt32(Console.ReadLine());
                }catch(Exception e){
                    Console.WriteLine("Error: Yang anda tebak bukan angka valid");
                }
                truth = cekTank();
                if(truth == 2)
                {
                    Console.WriteLine("tanknya hancur!");
                }
                else
                if(truth == 1)
                {
                    Console.WriteLine("Boom! Tanknya hancur!");
                    jB++;
                }
                else
                {
                    Console.WriteLine("Miss!tembakan Meleset!");
                }
                if(jB >= 3)
                {
                    Console.WriteLine("\nMenang!selamat Tank hancur semua!");
                    gstate=false;
                }
                Console.WriteLine();
            }
        }

        static void drawTank()
        {
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<5;j++)
                {
                    Console.Write(tank[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int cekTank()
        {
            for(int i=0;i<3;i++)
            {
                if(recent[i,0] == tebakan[0] && recent[i,1] == tebakan[1])
                {
                    return 2;
                }
            }
            for(int i=0;i<3;i++)
            {
                if(ans[i,0] == tebakan[0] && ans[i,1] == tebakan[1])
                {
                    tank[tebakan[0],tebakan[1]] = 'X';
                    recent[i,0] = tebakan[0];
                    recent[i,1] = tebakan[1];
                    return 1;
                }
                else
                {
                    tank[tebakan[0],tebakan[1]] = '0';
                }
            }
            return 0;
        }
    }
}