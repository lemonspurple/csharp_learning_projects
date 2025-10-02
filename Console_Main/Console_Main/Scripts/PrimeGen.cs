using System.Net;

public class PrimeGen
{

    public static void PrimeGeFunc()
    {
        bool quit = true;
        while (quit)
        {
            Console.WriteLine("How many prime numbers do you wanna print out?");
            string primeCount = Console.ReadLine();
            int loops; //number of loops

            bool success = int.TryParse(primeCount, out loops);
            if (success)
            {
                int prime = 2; // initial start number
                               //int seperator; // inserts break, if 10 numbers are in a row
                int divider = 2;
                int counter = 0;

                while (counter < loops)

                    if (divider == prime)
                    {
                        Console.Write((prime)+"\t");
                        prime++;
                        divider = 2;
                        counter++;
                        if (counter % 10 == 0)
                        { Console.WriteLine(); }
                    }
                    else if (prime % divider == 0)
                    {
                        prime++;
                        divider = 2;
                    }
                    else
                    {
                        divider++;
                    }
                Console.WriteLine();
                
            }
            else
            {
                Console.WriteLine("Input was not an integer.");
            }
        }

    }




}