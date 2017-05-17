using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moleCodeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am a Morse converter, give me any word, and I will give you its Morse equivalent:");
            String input = Console.ReadLine();
            input = input.ToUpper();


            /*  for (int i = 0; i < input.Length; i++)
              {
                  Console.WriteLine("I can do it");
              }
              */
            Console.Write("The Morse Code Eqivalent is:\t");

            string[] morse =  {" ",".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",
                ".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--..",".----","..---","...--","....-",".....",
                "-....","--...","---..","----.","-----" };

            foreach (var convert in input)
            {
                switch (convert)
                {
                    case ' ':
                        Console.Write(morse[0]);
                        break;
                    case 'A' :
                        Console.Write(morse[1]);
                        break;
                    case 'B':
                        Console.Write(morse[2]);
                        break;
                    case 'C':
                        Console.Write(morse[3]);
                        break;
                    case 'D':
                        Console.Write(morse[4]);
                        break;
                    case 'E':
                        Console.Write(morse[5]);
                        break;
                    case 'F':
                        Console.Write(morse[6]);
                        break;
                    case 'G':
                        Console.Write(morse[7]);
                        break;
                    case 'H':
                        Console.Write(morse[8]);
                        break;
                    case 'I':
                        Console.Write(morse[9]);
                        break;
                    case 'J':
                        Console.Write(morse[10]);
                        break;
                    case 'K':
                        Console.Write(morse[11]);
                        break;
                    case 'L':
                        Console.Write(morse[12]);
                        break;
                    case 'M':
                        Console.Write(morse[13]);
                        break;
                    case 'N':
                        Console.Write(morse[14]);
                        break;
                    case 'O':
                        Console.Write(morse[15]);
                        break;
                    case 'P':
                        Console.Write(morse[16]);
                        break;
                    case 'Q':
                        Console.Write(morse[17]);
                        break;
                    case 'R':
                        Console.Write(morse[18]);
                        break;
                    case 'S':
                        Console.Write(morse[19]);
                        break;
                    case 'T':
                        Console.Write(morse[20]);
                        break;
                    case 'U':
                        Console.Write(morse[21]);
                        break;
                    case 'V':
                        Console.Write(morse[22]);
                        break;
                    case 'W':
                        Console.Write(morse[23]);
                        break;
                    case 'X':
                        Console.Write(morse[24]);
                        break;
                    case 'Y':
                        Console.Write(morse[25]);
                        break;
                    case 'Z':
                        Console.Write(morse[26]);
                        break;
                    case '0':
                        Console.Write(morse[27]);
                        break;
                    case '1':
                        Console.Write(morse[28]);
                        break;
                    case '2':
                        Console.Write(morse[29]);
                        break;
                    case '3':
                        Console.Write(morse[30]);
                        break;
                    case '4':
                        Console.Write(morse[31]);
                        break;
                    case '5':
                        Console.Write(morse[32]);
                        break;
                    case '6':
                        Console.Write(morse[33]);
                        break;
                    case '7':
                        Console.Write(morse[34]);
                        break;
                    case '8':
                        Console.Write(morse[35]);
                        break;
                    case '9':
                        Console.Write(morse[36]);
                        break;
                  


                    default:
                        Console.Write(convert);
                        break;
                }


            }
            Console.ReadLine();

        }
    }
}
