using Entities;
using System;
using System.Collections.Generic;

namespace Business
{
    public class LCDFormatGenerator
    {
        private const string charSpace = " ";
        private const string charVertical = "|";
        private const string charHorizontal = "-";

        public static string Generate(LineCommand line)
        {
            string result = "";
            var LstBinaryMatrixNumber = new List<int[,]>();

            int size = line.Size;
            line.LstNumbers.ForEach(x => LstBinaryMatrixNumber.Add(MatrixCode.GetBinaryMatrixNumber(x)));

            for (int i = 0; i < 5; i++)
            {
                var newStringLine = "";
                for (int k = 0; k < LstBinaryMatrixNumber.Count; k++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (LstBinaryMatrixNumber[k][i, j] == 0)
                        {
                            if (j == 1)
                                for (int s = 0; s < size; s++)
                                    newStringLine += charSpace;
                            else
                                newStringLine += charSpace;
                        }
                        else
                        {
                            if ( i % 2 == 0)                            
                                for (int s = 0; s < size; s++)
                                    newStringLine +=  charHorizontal; 
                            
                            else                            
                                newStringLine += charVertical;                          
                        }

                    }                    
                }
                result += ValidateDuplicationLine(i, size, newStringLine);
            }         
            return result;
        }

        private static string ValidateDuplicationLine(int i, int size, string newStringLine)
        {
            var result = "";
            if (i % 2 == 0)
            {
                result += newStringLine;
                result += Environment.NewLine;
            }
            else
            {
                for (int s = 0; s < size; s++)
                {
                    result += newStringLine;
                    result += Environment.NewLine;
                }
            }

            return result;
        }
    }
}
