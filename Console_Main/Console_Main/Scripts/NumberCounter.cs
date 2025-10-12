class NumberCounter

{
public static void numberCounterFunc(List<decimal> input)
    {
        int counterOfElements = input.Count();
        decimal testValue = 9832712398971111111;
        int loopCounter = 0;
        int[] scale = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        Console.WriteLine($"\nTotal number of elements for analasys: {counterOfElements}");
        foreach(int element in scale)
        {
            string stringToBeAnalyzed = testValue.ToString();
            int count = stringToBeAnalyzed.Length - stringToBeAnalyzed.Replace((loopCounter.ToString()), "").Length;
            Console.WriteLine($"The numer {loopCounter} appeared {count} times.");
            loopCounter++;
        }
    }


}