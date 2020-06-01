using System;

namespace Random_Number_Generator
{
    using System.Collections;

    internal class Program
    {
        private static System.Collections.ArrayList list = new ArrayList();

        private static void Main(string[] args)
        {
            Console.Title = "Random Number Generator Based On Algorithm 1";
            Console.WriteLine("Hello, It is developed by Mr. Touraj Ostovari in order university home work! \n Y: 2020");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n  (based on your entry number would be generated next numbers, \n when reptative or 0 numbers appeared means your algo is exposed) \n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter your number: ");
            string num = Console.ReadLine();
            try
            {
                while (true)
                {

                    string temp = Math.Pow(double.Parse(num.ToString()), double.Parse("2")).ToString();
                    if ((temp.Length % 2) != 0) { temp = "0" + temp; }
                    string tempx = "";
                    for (int i = 2; i < temp.Length-2; i++)
                    {
                        tempx += (temp[i]);
                    }
                    
                    
                    if (!list.Contains(tempx)) { list.Add(tempx); }
                    else { break; }
                    Console.WriteLine(string.Concat("0.",tempx));
                    num = (tempx);
                }
            }
            catch (Exception)
            {

                goto End;
            }
        End:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("if 0. appeared means algo is exposed ...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nPress any key to exit ...");
            Console.ReadKey();
        }
    }
}
