class NumberCounter

{
    public static void numberCounterFunc(List<double> input)
    {
        List<double> inputCatcher = input;
        int counterOfElements = input.Count();
        int loopCounter = 0;
        int[] scale = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine($"\n\nTotal number of elements for analasys: {counterOfElements}");
        string combinedResults = DoubleToStringHelper(input);

        Console.WriteLine(combinedResults);
                foreach (int element in scale)
         {

             string stringToBeAnalyzed = combinedResults;

             int count = stringToBeAnalyzed.Length - stringToBeAnalyzed.Replace(scale[loopCounter].ToString(), "").Length;
             //Console.WriteLine($"The numer {scale[loopCounter]} appeared {count} times."); // WRITES OUT THE LIST AS STRING 
             if(loopCounter < 9)
             {
                 loopCounter++;
             }
         }
    }

    static string DoubleToStringHelper(List<double> input)
    {
        if (input == null || input.Count == 0)
            return "N";

        return string.Join(",", input);
    }


}