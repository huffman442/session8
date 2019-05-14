using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseInterpereter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string output = "";
            string[] morseTable = new string[37];
            string alphabet = "abcdefghijklmnopqrstuvwxyz1234567890 ";
            int index = 0;
            
            //to help write the table
            /*for (int i = 0; i < morseTable.Length; i++)
            {
                Console.WriteLine("morseTable[" + i + "] = \"\";");
            }*/
            morseTable[0] = ".-";
            morseTable[1] = "-...";
            morseTable[2] = "-.-.";
            morseTable[3] = "-..";
            morseTable[4] = ".";
            morseTable[5] = "..-.";
            morseTable[6] = "--.";
            morseTable[7] = "....";
            morseTable[8] = "..";
            morseTable[9] = ".---";
            morseTable[10] = "-.-";
            morseTable[11] = ".-..";
            morseTable[12] = "--";
            morseTable[13] = "-.";
            morseTable[14] = "---";
            morseTable[15] = ".--.";
            morseTable[16] = "--.-";
            morseTable[17] = ".-.";
            morseTable[18] = "...";
            morseTable[19] = "-";
            morseTable[20] = "..-";
            morseTable[21] = "...-";
            morseTable[22] = ".--";
            morseTable[23] = "-..-";
            morseTable[24] = "-.--";
            morseTable[25] = "--..";
            morseTable[26] = ".-----";
            morseTable[27] = "..---";
            morseTable[28] = "...--";
            morseTable[29] = "....-";
            morseTable[30] = ".....";
            morseTable[31] = "-....";
            morseTable[32] = "--...";
            morseTable[33] = "---..";
            morseTable[34] = "----.";
            morseTable[35] = "-----";
            morseTable[36] = " ";
            //for testing the table
            /*for (int i = 0; i < morseTable.Length; i++)
            {
                Console.WriteLine(morseTable[i]);
            }*/
            Console.WriteLine("Give me a message, sailor:");
            input = Console.ReadLine().ToLower();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (input[i] == alphabet[j])
                    {
                        index = j;
                    }
                }
                output += morseTable[index] + " ";
            }
            Console.WriteLine("Your message in morse code is: " + output);

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}