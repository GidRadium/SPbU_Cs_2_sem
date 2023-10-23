using System;
namespace Task11Game;

public class Game
{
    private char[,] field;
    private (int, int) playerPosition; // x, y
    private (int, int) fieldSize; // x - w, y - h

    public Game(string fileWithFieldPath)
    {
        this.LoadFieldFromFile(fileWithFieldPath);
        DrawField();
    }

    private void LoadFieldFromFile(string filePath)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException($"Can't open file {Path.GetFullPath(filePath)}");
        
        string[] lines = File.ReadAllLines(filePath);

        fieldSize = (lines[0].Length, lines.Length);
        field = new char[fieldSize.Item1, fieldSize.Item2];

        for (int i = 0; i < fieldSize.Item1; i++)
        {
            for (int j = 0; j < fieldSize.Item2; j++)
            {
                field[i, j] = lines[j][i];
                if (field[i, j] == '@')
                    playerPosition = (i, j);
            }
        }
    }

    private void DrawField()
    {
        Console.Clear();
        for (int i = 0; i < fieldSize.Item1; i++)
        {
            for (int j = 0; j < fieldSize.Item2; j++)
            {
                Console.SetCursorPosition(i, j);
                Console.Write(field[i, j]);
            }
        }

        Console.SetCursorPosition(playerPosition.Item1, playerPosition.Item2);
        Console.Write("@");
        Console.SetCursorPosition(fieldSize.Item1, fieldSize.Item2 - 1);
    }

    private void TryToMovePlayer((int, int) delta)
    {
        (int, int) newPlayerPos = (playerPosition.Item1 + delta.Item1, playerPosition.Item2 + delta.Item2);
        if (newPlayerPos.Item1 < 0) newPlayerPos.Item1 += fieldSize.Item1;
        if (newPlayerPos.Item2 < 0) newPlayerPos.Item2 += fieldSize.Item2;
        if (newPlayerPos.Item1 >= fieldSize.Item1) newPlayerPos.Item1 -= fieldSize.Item1;
        if (newPlayerPos.Item2 >= fieldSize.Item2) newPlayerPos.Item2 -= fieldSize.Item2;

        if (field[newPlayerPos.Item1, newPlayerPos.Item2] == '#')
            return;
        Console.SetCursorPosition(playerPosition.Item1, playerPosition.Item2);
        Console.Write(" ");
        Console.SetCursorPosition(newPlayerPos.Item1, newPlayerPos.Item2);
        Console.Write("@");
        playerPosition = newPlayerPos;
        Console.SetCursorPosition(fieldSize.Item1, fieldSize.Item2 - 1);
    }

    public void OnLeft(object sender, EventArgs args)
        => TryToMovePlayer((-1, 0));

    public void OnRight(object sender, EventArgs args)
        => TryToMovePlayer((1, 0));

    public void OnUp(object sender, EventArgs args)
        => TryToMovePlayer((0, -1));

    public void OnDown(object sender, EventArgs args)
        => TryToMovePlayer((0, 1));
}
