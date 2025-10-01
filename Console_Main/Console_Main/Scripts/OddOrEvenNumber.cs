public class OddOrEvenNumber{

    public static void OddOrEven(int[] variables)
    {
        foreach (int number in variables)
        {
            int testedVariable = number;
            if (testedVariable % 2 == 0)
            {
                System.Console.WriteLine(testedVariable);
            }

                continue;

        }
    }
}