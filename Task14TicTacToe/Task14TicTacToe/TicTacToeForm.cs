using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task14TicTacToe
{
    public partial class TicTacToeForm : Form
    {
        private TicTacToe ticTacToe = new TicTacToe();

        private void ClearAllButtons()
        {
            Button00.Text = " ";
            Button01.Text = " ";
            Button02.Text = " ";
            Button10.Text = " ";
            Button11.Text = " ";
            Button12.Text = " ";
            Button20.Text = " ";
            Button21.Text = " ";
            Button22.Text = " ";
        }

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

        public TicTacToeForm()
        {
            InitializeComponent();
        }

        private void Button00_Click(object sender, EventArgs e)
        {
            this.ticTacToe.Step(0, 0);
            Button00.Text = CellStateAsString(this.ticTacToe.GetCellState(0, 0));
            if (this.ticTacToe.GetWinner() != TicTacToe.CellState.Empty)
            {
                string message = "Game ends";
                string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    ClearAllButtons();
                    this.Close();
                }
            }
        }

        private void Button01_Click(object sender, EventArgs e)
        {
            this.ticTacToe.Step(0, 1);
            Button00.Text = CellStateAsString(this.ticTacToe.GetCellState(0, 1));
        }

        private void Button02_Click(object sender, EventArgs e)
        {
            this.ticTacToe.Step(0, 2);
            Button00.Text = CellStateAsString(this.ticTacToe.GetCellState(0, 2));
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.ticTacToe.Step(1, 0);
            Button00.Text = CellStateAsString(this.ticTacToe.GetCellState(1, 0));
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            this.ticTacToe.Step(1, 1);
            Button00.Text = CellStateAsString(this.ticTacToe.GetCellState(1, 1));
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            this.ticTacToe.Step(1, 2);
            Button00.Text = CellStateAsString(this.ticTacToe.GetCellState(1, 2));
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            this.ticTacToe.Step(2, 0);
            Button00.Text = CellStateAsString(this.ticTacToe.GetCellState(2, 0));
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            this.ticTacToe.Step(2, 2);
            Button00.Text = CellStateAsString(this.ticTacToe.GetCellState(2, 2));
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.ticTacToe.Step(2, 1);
            Button00.Text = CellStateAsString(this.ticTacToe.GetCellState(2, 1));
        }
    }
}
