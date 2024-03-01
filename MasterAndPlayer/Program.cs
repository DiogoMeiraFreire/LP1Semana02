using System;

namespace MasterAndPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for number
            Console.Write("Number Master insert number: ");
            int number1 = int.Parse(Console.ReadLine());

            if (number1 < 0 || number1 > 100)
            {
                Console.WriteLine
                ("Invalid number!");
                return;
            }

            // Write 100 blank lines
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("");
            }

            while(true)
            {
                Console.Write("Player insert number: "); 

                int number2 = int.Parse(Console.ReadLine());

                if(number2 < 0 || number2 > 100)
                {   
                    Console.WriteLine("Invalid number! Try Again!"); 
                }
                else
                {
                    int n = number2 - number1;
                    switch(MathF.Sign(n))
                    {
                        case -1:
                        {
                            Console.WriteLine
                            ($"The correct number is higher than {number2}");
                            break;
                        }
                        case 1:
                        {
                            Console.WriteLine
                            ($"The correct number is lower than {number2}");
                            break;
                        }
                        case 0:
                        {
                            Console.WriteLine("Player wins"); 
                            return;
                        }

                        default:
                            break;
                    }
                }

            }
        }
    }
}
