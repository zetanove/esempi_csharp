using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vettore=new int[10];
            vettore = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] vettore2 = { 2, 4, 6 };

            vettore2 = vettore;
            vettore2[0] = 33;
            Console.WriteLine("vettore[0]  = {0}",vettore[0]);
            Console.WriteLine("vettore2[0] = {0}",vettore2[0]);

            int[,] matrice= {
		        {1,2,3,4},
		        {5,6,7,8},
		        {9,10,11,12}
                            };


            int[][] jagged = new int[3][];
            jagged[0] = new int[1] { 1 };
            jagged[1] = new int[] { 2, 3 };

            int[] terza = { 4, 5, 6 };
            jagged[2] = terza;

        }
    }
}
