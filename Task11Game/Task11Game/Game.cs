namespace Task11Game;

using System;

/// <summary>
/// Main game class. Draws the field and handles user input.
/// </summary>
public class Game
{
    private Field field;

    /// <summary>
    /// Sets field and draws it.
    /// </summary>
    public Game(Field field)
    {
        this.field = field;
        DrawField();
    }

    private void DrawField()
    {
        Console.Clear();
        for (int i = 0; i < field.Size.Item1; i++)
        {
            for (int j = 0; j < field.Size.Item2; j++)
            {
                Console.SetCursorPosition(i, j);
                Console.Write(field.getFieldCell(i, j));
            }
        }

        Console.SetCursorPosition(field.PlayerPosition.Item1, field.PlayerPosition.Item2);
        Console.Write("@");
        Console.SetCursorPosition(field.Size.Item1, field.Size.Item2 - 1);
    }

    private void TryToMovePlayer((int, int) delta)
    {
        Console.SetCursorPosition(field.PlayerPosition.x, field.PlayerPosition.y);
        Console.Write(" ");
        field.TryToMovePlayer(delta);
        Console.SetCursorPosition(field.PlayerPosition.x, field.PlayerPosition.y);
        Console.Write("@");
        Console.SetCursorPosition(field.Size.w, field.Size.h - 1);
    }

    /// <summary>
    /// Left arrow handler.
    /// </summary>
    public void OnLeft(object sender, EventArgs args)
        => TryToMovePlayer((-1, 0));

    /// <summary>
    /// Right arrow handler.
    /// </summary>
    public void OnRight(object sender, EventArgs args)
        => TryToMovePlayer((1, 0));

    /// <summary>
    /// Up arrow handler.
    /// </summary>
    public void OnUp(object sender, EventArgs args)
        => TryToMovePlayer((0, -1));

    /// <summary>
    /// Down arrow handler.
    /// </summary>
    public void OnDown(object sender, EventArgs args)
        => TryToMovePlayer((0, 1));
}
