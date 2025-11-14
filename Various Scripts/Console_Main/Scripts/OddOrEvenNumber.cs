public class OddOrEvenNumber
{

    public static void OddOrEven(int[] variables) //TODO Overloads :D
    {
        foreach (int number in variables)
        {
            int testedVariable = number;
            if (testedVariable % 2 == 0)
            {
                System.Console.WriteLine(testedVariable);
            }


        }
    }
}