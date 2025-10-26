public class CellAutomata
{
    public static void linktest()
    {
        Console.WriteLine("CellAutomate.cs called");
    }
    
    public class Cell
    {
        private bool willBeAlive;
        public bool isAlive { get; set; }

        public void CalculateNextState(int livingNeighbors)
        {
            willBeAlive = willBeAliveFunc(livingNeighbors);
        }

        public void SwitchToNextState()
        {
            isAlive = willBeAlive;
        }
        
        private bool willBeAliveFunc(int livingNeighbors)
        {
            return true;
            /// TODO CONWAY LIFE THINGY RULES
        }
    }
}
