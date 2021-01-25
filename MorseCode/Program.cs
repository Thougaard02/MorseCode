using System;
using System.Text;

namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder morse = new StringBuilder();

            while (true)
            {
                Console.WriteLine("Indtast den tekst du ønsker at få oversat til morsekode");
                string text = Console.ReadLine();

                char[] chararray = text.ToCharArray();

                for (int i = 0; i < chararray.Length; i++)
                {
                    switch (chararray[i])
                    {
                        case 'a':
                            morse.Append(".-");
                            break;
                        case 'b':
                            morse.Append("-...");
                            break;
                        case 'c':
                            morse.Append("-.-.");
                            break;
                        case 'd':
                            morse.Append("-...");
                            break;
                        case 'e':
                            morse.Append(".");
                            break;
                        case 'f':
                            morse.Append("..-");
                            break;
                        case 'g':
                            morse.Append("--.");
                            break;
                        case 'h':
                            morse.Append("....");
                            break;
                        case 'i':
                            morse.Append("..");
                            break;
                        case 'j':
                            morse.Append(".---");
                            break;
                        case 'k':
                            morse.Append("-.-");
                            break;
                        case 'l':
                            morse.Append(".-..");
                            break;
                        case 'm':
                            morse.Append("--");
                            break;
                        case 'n':
                            morse.Append("-.");
                            break;
                        case 'o':
                            morse.Append("---");
                            break;
                        case 'p':
                            morse.Append(".--.");
                            break;
                        case 'q':
                            morse.Append("--.-");
                            break;
                        case 'r':
                            morse.Append(".-.");
                            break;
                        case 's':
                            morse.Append("...");
                            break;
                        case 't':
                            morse.Append("-");
                            break;
                        case 'u':
                            morse.Append("..-");
                            break;
                        case 'v':
                            morse.Append("...-");
                            break;
                        case 'w':
                            morse.Append(".--");
                            break;
                        case 'x':
                            morse.Append("-..-");
                            break;
                        case 'y':
                            morse.Append("-.--");
                            break;
                        case 'z':
                            morse.Append("--..");
                            break;
                        case 'æ':
                            morse.Append(".-.-");
                            break;
                        case 'ø':
                            morse.Append("---.");
                            break;
                        case 'å':
                            morse.Append(".--.-");
                            break;

                        default:
                            Console.Write(" ");
                            break;
                    }
                }
                Console.WriteLine(morse.ToString());
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
