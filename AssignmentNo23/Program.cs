using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo23
{
    class Program
    {
        // Multidimensional Arrays Assignment
        static void Main(string[] args)
        {
            int RowsNumber = 25;
            int ColumnsNumber = 7;
            int offset = 0;
            string[,] Array2D = new string[RowsNumber, ColumnsNumber];

            #region FillArrayManually
            //Array2D[0, 0] = "R0C0";
            //Array2D[0, 1] = "R0C1";
            //Array2D[0, 2] = "R0C2";
            //Array2D[1, 0] = "R1C0";
            //Array2D[1, 1] = "R1C1";
            //Array2D[1, 2] = "R1C2";
            //Array2D[2, 0] = "R2C0";
            //Array2D[2, 1] = "R2C1";
            //Array2D[2, 2] = "R2C2";
            //Array2D[3, 0] = "R3C0";
            //Array2D[3, 1] = "R3C1";
            //Array2D[3, 2] = "R3C2";
            //Array2D[5, 3] = "R5C3";
            //Array2D[6, 2] = "R6C2";
            //Array2D[10, 1] = "R10C1";
            //Array2D[10, 2] = "R10C2";
            //Array2D[10, 3] = "R10C3";
            //Array2D[10, 4] = "R10C4";
            //Array2D[10, 5] = "R10C5";
            //Array2D[9, 5] = "R9C5";
            //Array2D[8, 5] = "R8C5";
            //Array2D[11, 5] = "R11C5";
            //Array2D[10, 6] = "R10C6";
            //Array2D[12, 6] = "R12C6";
            //Array2D[14, 5] = "R14C5";
            //Array2D[15, 1] = "R15C1";
            //Array2D[15, 2] = "R15C2";
            #endregion

            #region FillArrayAutomatically
            FillArrayAutomatically(Array2D, RowsNumber, ColumnsNumber,offset);
            #endregion

            ShowInRowsAndColumnsFormat(Array2D, RowsNumber, ColumnsNumber, offset);

        }

        #region Methods Sections
        public static void FillArrayAutomatically(dynamic array2D, int row, int column, int numberOffset)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if(array2D.GetType().Name == "String[,]")
                        array2D[i, j] = "R" + (i+ numberOffset) + "C" + (j+ numberOffset);
                }
            }
        }

        public static void ShowInRowsAndColumnsFormat(dynamic array2D, int row, int column, int numberOffset)
        {
            for (int i = 0; i < column; i++)
            {
                Console.Write("\tColumn " + (i + numberOffset));
            }
            Console.WriteLine();
            for (int i = 0; i < column; i++)
            {
                Console.Write("\t--------");
            }
            Console.WriteLine();

            for (int i = 0; i < row; i++)
            {
                Console.Write("Row " + (i + numberOffset));
                for (int j = 0; j < column; j++)
                {
                    Console.Write("\t");
                    Console.Write(array2D[i, j]);
                    Console.Write("\t");
                    if (j == (column - 1))
                        Console.WriteLine();
                }
            }
        }
        #endregion
    }
}
