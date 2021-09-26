using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerConversionsApp
{
    class ComputerConversions
    {
        #region Calculus Methods
        public static string DecBin(string input)
        {
            List<long> storedValues = new List<long>();
            storedValues.Clear();

            double temp = double.Parse(input) * 2;

            while (temp > 1)
            {
                temp /= 2;
                temp = Math.Floor(temp);

                if (EvenNumber(temp))
                    storedValues.Add(0);
                else
                    storedValues.Add(1);
            }

            StringBuilder finalOutput = new StringBuilder();

            storedValues.Reverse();
            foreach (int cunt in storedValues)
            {
                finalOutput.Append(cunt.ToString());
            }

            return finalOutput.ToString();
        }

        public static string BinDec(string input)
        {
            int counter = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                counter += (Convert.ToInt32(input[input.Length - (i + 1)]) - 48) * (int)Math.Pow(2, i);
            }

            return counter.ToString();
        }

        public static string BinHex(string input)
        {
            const int binaryGroup = 4;
            //Calculate the number of "0" to add to complete the groups of 4 bits groups
            int completeInputNumber = binaryGroup - (input.Length % binaryGroup);

            //Add the "0" to the string based on the number calculated above to complete the 4bits groups
            string finalInput = input;
            for (int i = 0; i < completeInputNumber; i++)
            {
                finalInput = "0" + finalInput;
            }

            //Generate the 8421 list based on the number of groups
            string hexMultiplierArray = "";
            int index = (finalInput.Length / binaryGroup) + 1;
            do
            {
                hexMultiplierArray += "8421";
                index--;
            }
            while (index > 1);

            //Get the results values and store in a list
            List<string> resultList = new List<string>();
            int sum = 0;
            for (int i = 0; i < finalInput.Length; i++)
            {
                //Do the sum of groups of 4
                sum += (Convert.ToInt32(finalInput[i]) - 48) * (Convert.ToInt32(hexMultiplierArray[i]) - 48);

                if ((i + 1) % 4 == 0)
                {
                    if(sum != 0)
                    {
                        resultList.Add(sum.ToString());
                        sum = 0;
                    }
                }
            }

            //Convert the decimal results to the hexadecimal equivalent
            string finalOutput = "";
            foreach (string str in resultList)
            {
                finalOutput += Constants.DecHexEquivalent(str);
            }

            return "0x" + finalOutput;
        }

        public static string HexBin(string input)
        {
            string temp = "";
            for (int i = 0; i < input.Length; i++)
            {
                temp += Constants.HexBinEquivalent(input[i].ToString());
            }

            return temp;
        }

        public static string DecHex(string input)
        {
            return BinHex(DecBin(input));
        }

        public static string HexDec(string input)
        {
            return BinDec(HexBin(input));
        }

        private static bool EvenNumber(double input)
        {
            return input % 2 == 0 ? true : false;
        }
        #endregion
    }
}
