using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Task14TicTacToe
{
    

    public class TicTacToe
    {
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

        public void ClearField()
        {
            this.field = new CellState[3, 3];
        }

        public void Step(int x, int y)
        {
            if (this.GetWinner() == CellState.Empty &&  this.field[x, y] == CellState.Empty)
            {
                this.field[x, y] = (this.turn == Turn.Circle ? CellState.Circle : CellState.Cross);
                turn = (this.turn == Turn.Circle ? Turn.Cross : Turn.Circle);
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

        public CellState GetWinner()
        {
            int[] startX = { 0, 0, 0, 1, 0, 2, 0, 2 };
            int[] startY = { 0, 0, 0, 0, 1, 0, 2, 0 };
            int[] stepX =  { 1, 0, 1, 0, 1, 0, 1, -1 };
            int[] stepY =  { 0, 1, 1, 1, 0, 1, 0, 1 };

            for (int i = 0; i < startX.Length; i++)
                if (GetWinnerInRaw(startX[i], startY[i], stepX[i], stepY[i]) != CellState.Empty)
                    return GetWinnerInRaw(startX[i], startY[i], stepX[i], stepY[i]);

            return CellState.Empty;
        }

        public CellState GetCellState(int x, int y)
        {
            return this.field[x, y];
        }
    }
}
