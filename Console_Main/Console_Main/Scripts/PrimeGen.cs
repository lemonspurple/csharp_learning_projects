class PrimeGen
{
    public static List<int> primeList = new List<int>();

    public static void PrimeGenFunc(int row = 10)
    {
        // bool quit = true; //TODO Quit function :D
        while (true)
        {
            Console.WriteLine("How many prime numbers do you wanna print out?");
            string? primeCount = Console.ReadLine();
            float loops; //number of loops

            bool success = float.TryParse(primeCount, out loops);
            if (success)
            {
                int prime = 2; // initial start number
                int divider = 2;
                int counter = 0;
                

                while (counter < loops)
                
                    if (divider == prime) //prime found!
                    {
                        Console.Write((prime) + "\t");
                        PrimeGen.primeList.Add(prime);
                        prime++;
                        divider = 2;
                        counter++;
                        
                        // ADD PRIME TO LIST HERE
                        if (counter % row == 0)   // inserts linebreak, if constructor argument is given, otherwise after 10 results
                        { Console.WriteLine(); }
                    }
                    else if (prime % divider == 0) //loop hasn't found a prime
                    {
                        prime++;
                        divider = 2;
                    }
                    else //advance divider
                    {
                        divider++;
                    }
                Console.WriteLine();
                break;

            }
            else
            {
                Console.WriteLine("Input was not a valid number.");
            }
        }

    }




}