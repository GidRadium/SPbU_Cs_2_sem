using Task11Game;

var eventLoop = new EventLoop();
Game game;
try
{
    game = new Game("..\\..\\..\\Fields\\MainField.txt");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.Message);
    return;
}

eventLoop.LeftHandler += game.OnLeft;
eventLoop.RightHandler += game.OnRight;
eventLoop.UpHandler += game.OnUp;
eventLoop.DownHandler += game.OnDown;

eventLoop.Run();
