/* ########### ########### ###########
            Board Setup
Create a board out of booleans in two
dimensions and populate it by 40 active
cells.
 ########### ########### ########### */
int boardWidth = 20;
int boardHeight = 20;
int activeCells = 40; //TODO check if cells can receive active mutliple times
bool[,] board = new bool[boardWidth, boardHeight];
var random = new Random();

for (int i = 0; i < activeCells; i++) //populates the grid until activeCells is met
{
    board[random.Next(board.GetLength(0)), random.Next(board.GetLength(1))] = true;
}

// GetLength(0) references the first axis of boardWidth,
// (1) the second axis of boardheight

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
        for (int j = x - 1; j <= x + 1; j++)
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
             Debugging
 ########### ########### ########### */

/*
foreach(var item in board)
{
    Console.WriteLine(item.ToString());
}
*/