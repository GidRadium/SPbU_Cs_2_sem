using System;
using System.Windows.Forms;

namespace Task14TicTacToe;

/// <summary>
/// Main form of game app.
/// </summary>
public partial class TicTacToeForm : Form
{
    private TicTacToe ticTacToe = new TicTacToe();

    private void ClearAllButtons()
    {
        button00.Text = " ";
        button01.Text = " ";
        button02.Text = " ";
        button10.Text = " ";
        button11.Text = " ";
        button12.Text = " ";
        button20.Text = " ";
        button21.Text = " ";
        button22.Text = " ";
    }

    /// <returns>
    /// String implementation of CellState.
    /// </returns>
    private string CellStateAsString(TicTacToe.CellState CellState)
    {
        switch (CellState)
        {
            case TicTacToe.CellState.Circle:
                return "O";
            case TicTacToe.CellState.Cross:
                return "X";
            default:
                return " ";
        }
    }

    public TicTacToeForm() => InitializeComponent();

    /// <summary>
    /// Handles cell button click.
    /// </summary>
    private void OnCellButtonClick(object sender, EventArgs e)
    {
        var tag = (string)((System.Windows.Forms.Button)sender).Tag;
        var splitted = tag.Split(' ');
        int x = Int32.Parse(splitted[0]);
        int y = Int32.Parse(splitted[1]);

        this.ticTacToe.Step(x, y);
        ((System.Windows.Forms.Button)sender).Text = CellStateAsString(this.ticTacToe.GetCellState(x, y));
        if (this.ticTacToe.GetWinner() != TicTacToe.CellState.Empty || this.ticTacToe.IsDraw())
        {
            string message;
            if (this.ticTacToe.GetWinner() == TicTacToe.CellState.Cross)
                message = "First player wins!";
            else if (this.ticTacToe.GetWinner() == TicTacToe.CellState.Circle)
                message = "Second player wins!";
            else
                message = "Draw!";
            string caption = "Press OK to restart the game.";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ticTacToe.ClearField();
                ClearAllButtons();
            }
        }
    }
}
