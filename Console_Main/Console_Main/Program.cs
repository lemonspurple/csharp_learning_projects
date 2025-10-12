namespace Console_Main;
class Program
{
    static int loops = 0;
    static bool isRunning = true;
    static void Main(string[] args)
    {
        /*
                string[] words = { "aLorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy",
                "eirmod atempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et",
                "accusam et justo duo dolores et ea rebum. Stet clita kasdire gubergren, no sea takimata sanctus est Lorem"};
                int[] variables = { 2, 3, 4, 5, 1, 2, 6, 8, 9, 5, 43, 12 };
                int test = 4;
        */
        while(isRunning){
        Console.WriteLine("Do you wanna calculate Prime Numbers (1), Fibonacci Numbers (2) or quit (Q)?");
        string decision = Console.ReadLine();
        switch (decision)
        {
            case "1":
            PrimeCalculate();
                break;
                            case "2":
            FibonacciCalculate();
                break;
                                         case "Q":
                isRunning = false; ;
                break;
            default:
                break;
        }
}

        /*
        Which prime numbers are also fibbonaci?
        What is the distance between them?
        What does Numbercounter show?
        */

        //FibonacciCalculate();
        // Console.WriteLine("test".GetType());

        // OddOrEvenNumber.OddOrEven(variables);
        // DoesItStartWithX.LoopThatDetectsIfSomethingStartsWithX(words2, 'a');































    }

    private static void PrimeCalculate()
    {
        PrimeGen.PrimeGenFunc(15);
        List<double> doubleList = PrimeGen.primeList.ConvertAll(x => (double)x);
        NumberCounter.numberCounterFunc(doubleList);
    }

    private static void FibonacciCalculate()
    {
        FibonacciGen.FibonacciGenGenFunc();
        foreach (double result in FibonacciGen.fibGenCacheList)
        {
            Console.Write($"{result} \t");
            loops++;
            if (loops % 10 == 0)
            {
                Console.WriteLine();
            }
        }
        NumberCounter.numberCounterFunc(FibonacciGen.fibGenCacheList);
    }
}
