namespace ConsoleApp1
{
    public class TicTacToeLogic
    {
        private const int GridDimension = 4;        
        public bool IsWin(int[] spaces, int whoseTurn)
        {
            int matchesNumber = 0;

            //check horizontal lines
            for (int i = 0; i < GridDimension; i++)
            {
                matchesNumber = 0;
                for (int j = 0; j < GridDimension; j++)
                {
                    if (spaces[i * GridDimension + j] == whoseTurn)
                    {
                        matchesNumber++;
                    }

                    //that means the player won
                    if (matchesNumber == GridDimension)
                    {
                        return true;
                    }
                }
            }

            //check vertical lines
            for (int i = 0; i < GridDimension; i++)
            {
                matchesNumber = 0;
                for (int j = 0; j < GridDimension; j++)
                {
                    if (spaces[j * GridDimension + i] == whoseTurn)
                    {
                        matchesNumber++;
                    }

                    //that means the player won
                    if (matchesNumber == GridDimension)
                    {
                        return true;
                    }
                }
            }


            var diagonalIndex = 0;

            matchesNumber = 0;
            //check diagonal lines
            for (int i = 0; i < GridDimension; i++)
            {
                if (i == 0)
                {
                    diagonalIndex = 0;
                }
                else
                {
                    diagonalIndex = i * GridDimension + i;
                }

                if (spaces[diagonalIndex] == whoseTurn)
                {
                    matchesNumber++;
                }

                //that means the player won
                if (matchesNumber == GridDimension)
                {
                    return true;
                }
            }

            matchesNumber = 0;
            //check reverse diagonal lines
            for (int i = GridDimension - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    diagonalIndex = GridDimension - 1;
                }
                else
                {
                    diagonalIndex = i * GridDimension + GridDimension - i - 1;
                }

                if (spaces[diagonalIndex] == whoseTurn)
                {
                    matchesNumber++;
                }

                //that means the player won
                if (matchesNumber == GridDimension)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
