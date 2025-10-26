/* ########### ########### ###########
            Board Setup
Create a board out of booleans in two
dimensions and populate it by 40 active
cells.
 ########### ########### ########### */
int boardWidth = 200;
int boardHeight = 75;
int activeCells = 2000; //TODO check if cells can receive active mutliple times
bool[,] board = new bool[boardWidth, boardHeight];
var random = new Random();

for (int i = 0; i < activeCells; i++) //populates the grid until activeCells is met
{
    board[random.Next(board.GetLength(0)), random.Next(board.GetLength(1))] = true;
}

// GetLength(0) references the first axis of boardWidth,
// (1) the second axis of boardheight

/* ########### ########### ###########
            Refreshing the
                console
 ########### ########### ########### */

bool[,] calculateGeneration(bool[,] currentGeneration)
{
    bool[,] newGeneration = new bool[boardWidth, boardHeight];
    for (int x = 0; x < board.GetLength(0); x++)
    {
        for (int y = 0; y < board.GetLength(1); y++)
        {
            newGeneration[x, y] = gameOfLife(currentGeneration, x, y);
        }
    }
    return newGeneration;
}

/* ########### ########### ###########
            ProcessNeighbors
We check the 8 surrounding cells for
living cells, rule out that it's not
yourself and part of the board.
 ########### ########### ########### */

int ProcessNeighbors(bool[,] board, int x, int y)
{
    int checkNeighbors = 0;
    for (int i = x - 1; i <= x + 1; i++) //gives 9 iterations
    {
        for (int j = y - 1; j <= y + 1; j++)
        {
            if (isPartOfBoard(i, j, board.GetLength(0), board.GetLength(1)) && // is cell part of my grid?
            !isYourself(x, y, i, j) && // is the cell NOT me?
            board[i, j]) // is the cell alive?
            {
                checkNeighbors++;
            }
        }
    }
    return checkNeighbors;
}

bool isPartOfBoard(int i, int j, int rows, int columns)
{
    return i >= 0 && i < rows && j >= 0 && j < columns;
}

bool isYourself(int x, int y, int i, int j)
{
    return x == i && y == j;
}

/* ########### ########### ###########
            Game of Life
if the cell is alive and has either 0-1
or 4 or more neighbors it is set to false.
If cell is not alive and has 3 neighbors it
set to true.
Only sorts. Value is calculated in ProcessNeighbors()
 ########### ########### ########### */

bool gameOfLife(bool[,] board, int x, int y)
{
    int neighbors = ProcessNeighbors(board, x, y);
    if (board[x, y] == true)
    {
        if (neighbors <= 1 || neighbors >= 4)
        {
            return false;
        }
        return true;
    }
    else
    {
        if (board[x, y] == false && neighbors == 3) // TODO remove board for opti ?
        {
            return true;
        }
        return false;
    }
}


/* ########### ########### ###########
                Start
 ########### ########### ########### */
void drawBoard(int x, int y, bool isActive)
{
    Console.SetCursorPosition(x, y);
    if (!isActive)
        Console.BackgroundColor = ConsoleColor.Black;
    else
        Console.BackgroundColor = ConsoleColor.White;
    Console.Write(" ");
}

while (true)
{
    board = calculateGeneration(board);
    for (int x = 0; x < board.GetLength(0); x++)
    {
        for (int y = 0; y < board.GetLength(1); y++)
        {
            drawBoard(x, y, board[x, y]);
        }
    }
    Thread.Sleep(50);
}


/* ########### ########### ###########
             Debugging
 ########### ########### ########### */

/*
foreach(var item in board)
{
    Console.WriteLine(item.ToString());
}
*/