using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [ 2D ]

            int[,] my2DArray = new int[2, 3];

            int[,] my2DArray2 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            int[,] my2DArray4 = new int[4, 3] { { 10, 20, 30 }, { 3, 4, 3 }, { 5, 6, 3 }, { 7, 8, 3 } };

            int[,] my2DArray3 = { { 1, 2, 3 }, { 4, 5, 6 } };

            #endregion

            #region [ jadvalZarb ]

            int[,] jadvalZarb = new int[10, 10];

            // به ازای هر بار اجرای حلقه بیرونی ، حلقه درونی کامل اجرا میشود

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    jadvalZarb[i, j] = (i + 1) * (j + 1); // 10 * 10 بار اجرا میشود
                }
            }

            #endregion

            #region [ 3D ]

            int[,,] my3DArray = new int[2, 3, 4]; // 24

            int length = my3DArray.Length; //24

            int total = 1;

            for (int i = 0; i < my3DArray.Rank; i++)
            {
                total *= my3DArray.GetLength(i); //24
            }

            Console.WriteLine("{0} = {1}", length, total);


            int[,,,,] my5DArray = new int[2, 3, 4, 3, 2]; // 144


            //--------- Reset

            length = my5DArray.Length;
            total = 1;

            for (int i = 0; i < my5DArray.Rank; i++)
            {
                total *= my5DArray.GetLength(i); // 144
            }

            Console.WriteLine("{0} = {1}", length, total);



            #endregion


            #region [Jagged Arrays]

            // Array of Arrays !! Jagged Arrays !!

            int[][] myJaggedArray = new int[3][];

            myJaggedArray[0] = new int[4] { 1, 2, 3, 4 };
            myJaggedArray[1] = new int[3] { 1, 2, 3 };
            myJaggedArray[2] = new int[2] { 1, 2 };
            //  myJaggedArray[3] = new int[1] { 1 };




            int[][] myJaggedArray2 = new int[][]
            {
                new int[] {1,2,3,4,5},
                new int[] {1,2,3},
                new int[] {1,2}
            };

            //  myJaggedArray2[2][2] = 2222; // index out of renge


            int[][] myJaggedArray3 = new int[][]
           {
                //new string[] {"",""},
                new int[] {1,2,3},
                new int[] {1,2}
           };


            #endregion

            Console.ReadKey();

        }
    }
}
