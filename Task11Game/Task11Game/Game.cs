﻿namespace Task11Game;

public class Game
{
    public void OnLeft(object sender, EventArgs args)
        => Console.WriteLine("Going left");

    public void OnRight(object sender, EventArgs args)
        => Console.WriteLine("Going right");

    public void OnUp(object sender, EventArgs args)
        => Console.WriteLine("Going up");

    public void OnDown(object sender, EventArgs args)
        => Console.WriteLine("Going down");
}
