using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerConversionsApp
{
    class Constants
    {
        public static string DecHexEquivalent(string input)
        {
            switch (input)
            {
                case "0":
                    return "0";
                case "1":
                    return "1";
                case "2":
                    return "2";
                case "3":
                    return "3";
                case "4":
                    return "4";
                case "5":
                    return "5";
                case "6":
                    return "6";
                case "7":
                    return "7";
                case "8":
                    return "8";
                case "9":
                    return "9";
                case "10":
                    return "A";
                case "11":
                    return "B";
                case "12":
                    return "C";
                case "13":
                    return "D";
                case "14":
                    return "E";
                case "15":
                    return "F";
                default:
                    return "";
            }
        }

        public static string HexBinEquivalent(string input)
        {
            switch (input)
            {
                case "0":
                    return "0000";
                case "1":
                    return "0001";
                case "2":
                    return "0010";
                case "3":
                    return "0011";
                case "4":
                    return "0100";
                case "5":
                    return "0101";
                case "6":
                    return "0110";
                case "7":
                    return "0111";
                case "8":
                    return "1000";
                case "9":
                    return "1001";
                case "A":
                    return "1010";
                case "B":
                    return "1011";
                case "C":
                    return "1100";
                case "D":
                    return "1101";
                case "E":
                    return "1110";
                case "F":
                    return "1111";
                default:
                    return "";
            }
        }

    }
}
