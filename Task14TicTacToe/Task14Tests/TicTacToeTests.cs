namespace Task14Tests;

using Task14TicTacToe;

/// <summary>
/// Tests for TicTacToe class
/// </summary>
public class TicTacToeTests
{
    private TicTacToe ticTacToe;

    [SetUp]
    public void Setup()
        => ticTacToe = new();

    [Test]
    public void TicTacToeNoWinnerWhenEmpty()
        => Assert.That(ticTacToe.GetWinner(), Is.EqualTo(TicTacToe.CellState.Empty));

    [Test]
    public void TicTacToeCrossCanWin()
    {
        ticTacToe.Step(0, 0);
        ticTacToe.Step(0, 1);
        ticTacToe.Step(1, 1);
        ticTacToe.Step(2, 1);
        ticTacToe.Step(2, 2);
        Assert.That(ticTacToe.GetWinner(), Is.EqualTo(TicTacToe.CellState.Cross));
    }

    [Test]
    public void TicTacToeCircleCanWin()
    {
        ticTacToe.Step(2, 0);
        ticTacToe.Step(0, 0);
        ticTacToe.Step(0, 1);
        ticTacToe.Step(1, 1);
        ticTacToe.Step(2, 1);
        ticTacToe.Step(2, 2);
        Assert.That(ticTacToe.GetWinner(), Is.EqualTo(TicTacToe.CellState.Circle));
    }
}
