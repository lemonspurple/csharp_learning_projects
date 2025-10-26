public class Environment{
    public int width;
    public int height;


    public void DrawEnvironment(width = 10, height = 10){
        for (int i = 0; i >= width; i++){
            Console.Write("X");
            for (int i = 0; i >= height;  i++){
                Console.WriteLine();
            }
        }
    }
    
}