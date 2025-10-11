
class FibonacciGen
{

    public static void FibonacciGenGenFunc()
    {
        Console.WriteLine("test");
        int input = FibonacciGenInput();
        CalculateFibonacci(input);

    }

   private static int FibonacciGenInput()
    {
        bool success = false;
        int FibonacciCounter=1;
        while (!success)
        {
            Console.WriteLine("How many Fibonacci Numbers would you like to calculate?");
            string input = Console.ReadLine();


            if (int.TryParse(input, out FibonacciCounter))
            {
                Console.WriteLine("Number is valid. Calculating...");
                success = true;
            }
            else
            {
                Console.WriteLine("Invalid number.");

            }
        }
        return FibonacciCounter;
    }

    private static void CalculateFibonacci(int input)
    {
        double holder = 0;
        double starter = 1;
        double result;
        double loopcounter = 0;
        while(loopcounter != input)
        {
            result = starter + holder;
            holder = starter;
            Console.Write((result) + "\t");
            starter = result;
            loopcounter++;
            if(loopcounter%10==0)
            {
                Console.WriteLine();
            }
        }
    }
    //TODO: save results into a list and make statistics about which number comes up the most OR which first number is how often represented


}