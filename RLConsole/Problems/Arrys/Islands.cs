using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLConsole.Problems.Arrys
{
    //http://www.geeksforgeeks.org/count-number-islands-every-island-separated-line/
    //Statement : Count number of islands where every island is row-wise and column-wise separated.
    //Problem Desctription:
    //Given a rectangular matrix which has only two possible values ‘X’ and ‘O’. The values ‘X’ always appear in form of rectangular islands and these islands are always row-wise and column-wise separated by at least one line of ‘O’s. Note that islands can only be diagonally adjacent. Count the number of islands in the given matrix.

    //Examples:
    //mat[M][N] =  {{'O', 'O', 'O'},
    //              {'X', 'X', 'O'},
    //              {'X', 'X', 'O'},
    //              {'O', 'O', 'X'},
    //              {'O', 'O', 'X'},
    //              {'X', 'X', 'O'}
    //             };
    //Output: Number of islands is 3

    //mat[M][N] =  {{'X', 'O', 'O', 'O', 'O', 'O'},
    //              {'X', 'O', 'X', 'X', 'X', 'X'},
    //              {'O', 'O', 'O', 'O', 'O', 'O'},
    //              {'X', 'X', 'X', 'O', 'X', 'X'},
    //              {'X', 'X', 'X', 'O', 'X', 'X'},
    //              {'O', 'O', 'O', 'O', 'X', 'X'},
    //             };
    //Output: Number of islands is 4
    public class Islands
    {

        /// <summary>
        /// Counts the number of islands in the given matrix.
        /// </summary>
        /// <param name="mat">Content in the matrix can only be either 'X' or 'O' (case sensitive).</param>
        public static int CountIslands(char[,] mat)
        {
            int colLength = mat.GetLength(0);
            int rowLength = mat.GetLength(1);

            int count = 0;


            for (int i = 0; i < colLength; i++)
            {
                for (int j = 0; j < rowLength; j++)
                {
                    if (mat[i, j] == 'X')
                    {
                        if ((i != 0 && j != 0) && (mat[i - 1, j] == 'O' && mat[i, j - 1] == 'O'))
                        {
                            count++;
                        }
                        else if (i == 0 || j == 0)
                        {

                            if (i == 0 && j == 0)
                            {
                                count++;
                            }
                            else if ((j == 0 && mat[i - 1, j] == 'O') || (i == 0 && mat[i, j - 1] == 'O'))
                            {
                                count++;
                            }

                        }
                    }
                }

            }

            return count;
        }




        public static void FindFirstPetrol(int[] petrol, int[] distance)
        {
            int reserve = 0;
            int tank = 0;
            bool flag = false;

            int index = 0;
            for (int i = 0; i < petrol.Length; i++)
            {
                tank = petrol[i] + reserve - distance[i];
                if (tank >= 0)
                {
                    reserve = tank;
                    if (!flag)
                    {
                        index = i;
                        flag = true;
                    }
                }
                else
                {
                    reserve = tank;
                    flag = false;
                }
            }

            if (reserve >= 0)
            {
                Console.WriteLine("Starting Index should be: " + index);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

    }
}
