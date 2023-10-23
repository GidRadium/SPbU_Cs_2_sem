namespace Task11Game;

public class Field
{
    public char[,] Data { get; }
    public (int w, int h) Size { get; }
    public (int x, int y) PlayerPosition { get; private set; }
    
    public Field(string fileWithFieldPath)
    {
        if (!File.Exists(fileWithFieldPath))
            throw new FileNotFoundException($"Can't open file {Path.GetFullPath(fileWithFieldPath)}");

        string[] lines = File.ReadAllLines(fileWithFieldPath);

        Size = (lines[0].Length, lines.Length);
        Data = new char[Size.w, Size.h];

        for (int i = 0; i < Size.w; i++)
        {
            for (int j = 0; j < Size.h; j++)
            {
                Data[i, j] = lines[j][i];
                if (Data[i, j] == '@')
                    PlayerPosition = (i, j);
            }
        }
    }

    public void TryToMovePlayer((int x, int y) delta)
    {
        (int x, int y) newPlayerPos = (PlayerPosition.x + delta.x, PlayerPosition.y + delta.y);
        if (newPlayerPos.x < 0) newPlayerPos.x += Size.w;
        if (newPlayerPos.y < 0) newPlayerPos.y += Size.h;
        if (newPlayerPos.x >= Size.w) newPlayerPos.x -= Size.w;
        if (newPlayerPos.y >= Size.h) newPlayerPos.y -= Size.h;

        if (Data[newPlayerPos.x, newPlayerPos.y] == '#')
            return;

        this.PlayerPosition = newPlayerPos;
    }
}
