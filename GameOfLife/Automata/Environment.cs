public class Environment
{

    public void DrawEnvironment(int width, int height)
    {

        for (int n = 0; n <= height; n++)
        {
            for (int i = 0; i <= width; i++)
            {
                Console.Write("X");
            }
            Console.WriteLine("Y");
        }

    }

}