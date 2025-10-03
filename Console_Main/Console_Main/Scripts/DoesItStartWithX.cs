public class DoesItStartWithX
{

    public static void LoopThatDetectsIfSomethingStartsWithX(string[] inputWords, char valueToDetect) //TODO Overloads :D
    {
        foreach (string line in inputWords)
        {
            string[] elements = line.Split(" "); // splits sentence when space is detected
            foreach (string elem in elements)
            {
                if (elem.StartsWith(valueToDetect)) //tries to valueToDetect in each elem from elements
                {
                    Console.WriteLine(elem);
                }
            }

        }
    }
}