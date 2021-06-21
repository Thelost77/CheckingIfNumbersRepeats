using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Program
    {

        private static bool IfNumberRepeats(int number1, int number2)
        {
            char previousNumber = char.MinValue;
            char previousPreviousNumber = char.MinValue;
            char previousNumber2 = char.MinValue;
            int comparator = 0;
            int i = 0;
            foreach(char number in number1.ToString())
            {
                comparator = int.Parse(number.ToString());               
                if (number == previousNumber)
                {
                    if (previousNumber == previousPreviousNumber)
                        foreach(char numberr in number2.ToString())
                        {
                            if (int.Parse(numberr.ToString()) == comparator )
                                if (numberr == previousNumber2)
                                    return true;
                            previousNumber2 = numberr;
                        }

                    previousPreviousNumber = previousNumber;
                }
                previousNumber = number;
                i++;
                if (i == number1.ToString().Length)
                    return false;               
                
            }




            return true;
        }
        static void Main(string[] args)
        {
            string ifYouWantToExit = "tak";
            while (ifYouWantToExit == "tak")
            {
                Console.WriteLine("\nCześć, sprawdzam czy jakaś cyfra powtarza się 3 razy w dwóch podanych liczbach.\n");
                Console.WriteLine("\nWprowadź pierwszą liczbę\n");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nWprowadź drugą liczbę\n");
                int number2 = int.Parse(Console.ReadLine());
                if (IfNumberRepeats(number1, number2))
                    Console.WriteLine("\nTak liczba się powtarza!\n");
                else
                    Console.WriteLine("\nNiestety liczba się nie powtarza. :(\n");
                Console.WriteLine("\nJeśli chcesz sprawdzić jeszcze raz wpisz 'tak', jeśli chcesz wyjść wciśnij dowolny przycisk\n");
                ifYouWantToExit = Console.ReadLine();

            }
            

            
            

        }
    }
}
