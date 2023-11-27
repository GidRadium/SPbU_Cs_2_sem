using System.Diagnostics;

namespace Task11Game;

/// <summary>
/// Game field data class. Also cantains player and moves it;
/// </summary>
public class Field
{
    private char[,] data;

    /// <returns>Field cell (char) by its coords.</returns>
    public char getFieldCell(int x, int y) => data[x, y];

    /// <summary>
    /// Field width and height.
    /// </summary>
    public (int w, int h) Size { get; }

    /// <summary>
    /// Player position coords.
    /// </summary>
    public (int x, int y) PlayerPosition { get; private set; }
    
    /// <summary>
    /// Field class constructor. Loads data from file.
    /// </summary>
    /// <exception cref="FileNotFoundException"></exception>
    /// <exception cref="IncorrectFieldException"></exception>
    public Field(string fileWithFieldPath)
    {
        if (!File.Exists(fileWithFieldPath))
            throw new FileNotFoundException($"Can't open file {Path.GetFullPath(fileWithFieldPath)}");

        string[] lines = File.ReadAllLines(fileWithFieldPath);

        int maxLineLength = 0;
        foreach (var line in lines)
            maxLineLength = Math.Max(maxLineLength, line.Length);

        Size = (maxLineLength, lines.Length);
        data = new char[Size.w, Size.h];

        int playersCount = 0;

        for (int i = 0; i < Size.w; i++)
        {
            for (int j = 0; j < Size.h; j++)
            {
                if (lines[j].Length <= i)
                {
                    data[i, j] = '#';
                    continue;
                }
                
                data[i, j] = (lines[j][i] == '#' ? '#' : ' ');
                
                if (lines[j][i] == '@')
                {
                    this.PlayerPosition = (i, j);
                    playersCount++;
                }
            }
        }

        if (playersCount != 1)
            throw new IncorrectFieldException();
    }

    /// <summary>
    /// Moves player by the delta if it is possible. Player can teleport throught field boundary.
    /// </summary>
    public void TryToMovePlayer((int x, int y) delta)
    {
        (int x, int y) newPlayerPos = (PlayerPosition.x + delta.x, PlayerPosition.y + delta.y);
        if (newPlayerPos.x < 0) newPlayerPos.x += Size.w;
        if (newPlayerPos.y < 0) newPlayerPos.y += Size.h;
        if (newPlayerPos.x >= Size.w) newPlayerPos.x -= Size.w;
        if (newPlayerPos.y >= Size.h) newPlayerPos.y -= Size.h;

        if (data[newPlayerPos.x, newPlayerPos.y] == '#')
            return;

        this.PlayerPosition = newPlayerPos;
    }
}
