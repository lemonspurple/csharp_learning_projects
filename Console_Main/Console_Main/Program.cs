namespace Console_Main;
class Program
{
    static int loops = 0;
    
    static void Main(string[] args)
    {
        //PrimeGen f = new PrimeGen();
        /*
                string[] words = { "aLorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy",
                "eirmod atempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et",
                "accusam et justo duo dolores et ea rebum. Stet clita kasdire gubergren, no sea takimata sanctus est Lorem"};
                int[] variables = { 2, 3, 4, 5, 1, 2, 6, 8, 9, 5, 43, 12 };
                int test = 4;
        */
        //PrimeGen.PrimeGenFunc(15);
        
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
       // Console.WriteLine("test".GetType());

        // OddOrEvenNumber.OddOrEven(variables);
        // DoesItStartWithX.LoopThatDetectsIfSomethingStartsWithX(words2, 'a');































    }
}
