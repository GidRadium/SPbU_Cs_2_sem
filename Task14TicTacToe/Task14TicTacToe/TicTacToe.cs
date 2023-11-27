namespace Task14TicTacToe;

/// <summary>
/// Data of TicTacToe game.
/// </summary>
public class TicTacToe
{
    /// <summary>
    /// Enum class for state of game's cell.
    /// </summary>
    public enum CellState
    {
        Empty,
        Cross,
        Circle
    }

    private enum Turn
    {
        Cross,
        Circle
    }

    private Turn turn;

    private CellState[,] field = new CellState[3, 3];

    /// <summary>
    /// Clears field.
    /// </summary>
    public void ClearField()
        => this.field = new CellState[3, 3];

    /// <summary>
    /// Updates field after user step.
    /// </summary>
    public void Step(int x, int y)
    {
        if (this.GetWinner() == CellState.Empty && this.field[x, y] == CellState.Empty)
        {
            this.field[x, y] = (this.turn == Turn.Circle ? CellState.Circle : CellState.Cross);
            this.turn = (this.turn == Turn.Circle ? Turn.Cross : Turn.Circle);
        }
    }

    private CellState GetWinnerInRaw(int startX, int startY, int stepX, int stepY)
    {
        if (this.field[startX, startY] == this.field[startX + stepX, startY + stepY]
            && this.field[startX, startY] == this.field[startX + stepX * 2, startY + stepY * 2])
        {
            return this.field[startX, startY];
        }

        return CellState.Empty;
    }

    /// <summary>
    /// Calculates the winner of the game.
    /// </summary>
    /// <returns>
    /// CellState.Empty if game is not ended.
    /// CellState.Cross if first player wins.
    /// CellState.Circle if second player wins.
    /// </returns>
    public CellState GetWinner()
    {
        int[] startX = { 0, 0, 0, 1, 0, 2, 0, 2 };
        int[] startY = { 0, 0, 0, 0, 1, 0, 2, 0 };
        int[] stepX = { 1, 0, 1, 0, 1, 0, 1, -1 };
        int[] stepY = { 0, 1, 1, 1, 0, 1, 0, 1 };

        for (int i = 0; i < startX.Length; i++)
            if (GetWinnerInRaw(startX[i], startY[i], stepX[i], stepY[i]) != CellState.Empty)
                return GetWinnerInRaw(startX[i], startY[i], stepX[i], stepY[i]);

        return CellState.Empty;
    }

    /// <summary>
    /// Checks game state is draw.
    /// </summary>
    /// <returns>
    /// True if field is full. Otherwise - false.
    /// </returns>
    public bool IsDraw()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                if (this.field[i, j] == CellState.Empty)
                    return false;

        return true;
    }

    /// <returns>
    /// Cell current state.
    /// </returns>
    public CellState GetCellState(int x, int y)
        => this.field[x, y];
}
