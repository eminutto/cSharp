using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class SymmetricMatrix
    {
        public SymmetricMatrix()
        {

        }

        public string CheckIfSymmetricMatrix(string[] strArray)
        {
            int arrRow = 1;
            int arrCol = 0;

            foreach (var item in strArray)
            {
                if (item == "<>")
                {

                    arrRow++;

                }
                else if (arrRow == 1 && item != "<>")
                {
                    arrCol++;
                }
            }

            if (arrRow != arrCol)
            {
                Console.WriteLine("Row: " + arrRow);
                Console.WriteLine("Col: " + arrCol);
                return "Not possible";
            }
            else
            {
                string[,] stringArray = new string[arrRow, arrCol];
                string[,] transArray = new string[arrRow, arrCol];


                arrRow = 0;
                arrCol = 0;

                for (int i = 0; i < strArray.Length; i++)
                {
                    if (strArray[i] == "<>")
                    {
                        arrRow++;
                        arrCol = 0;
                    }
                    else
                    {
                        stringArray[arrRow, arrCol] = strArray[i];
                        arrCol++;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Row: " + arrRow);
                Console.WriteLine("Col: " + arrCol);

                for (int i = 0; i < stringArray.GetLength(0); i++)
                {
                    for (int j = 0; j < stringArray.GetLength(1); j++)
                    {
                        Console.Write(stringArray[i, j] + " ");
                    }
                }

                Console.WriteLine();
                Console.WriteLine();

                //Trans
                for (int i = 0; i < arrCol; i++)
                {
                    for (int j = 0; j <= arrRow; j++)
                    {
                        transArray[j, i] = stringArray[i, j];
                    }
                }

                //Display
                for (int i = 0; i < transArray.GetLength(0); i++)
                {
                    for (int j = 0; j < transArray.GetLength(1); j++)
                    {
                        Console.Write(transArray[i, j] + " ");
                    }
                }

                Console.WriteLine();
                
                //Compare
                for (int i = 0; i < arrCol; i++)
                {
                    for (int j = 0; j <= arrRow; j++)
                    {
                        if (transArray[i, j] == stringArray[i, j])
                        {
                            Console.Write("{0}, {1} ", transArray[i, j], stringArray[i, j]);
                            Console.WriteLine("Sym");
                        }
                        else
                        {
                            Console.Write("{0}, {1} ", transArray[i, j], stringArray[i, j]);
                            return "not Symetric";
                        }
                    }
                }
                return "Symetric!!";
            }
        }

    }
}
