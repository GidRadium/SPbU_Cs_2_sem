using Task11Game;

Field field;
try
{
    field = new Field("../../../Fields/MainField.txt");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.Message);
    return;
}

var game = new Game(field);

var eventLoop = new EventLoop();
eventLoop.LeftHandler += game.OnLeft;
eventLoop.RightHandler += game.OnRight;
eventLoop.UpHandler += game.OnUp;
eventLoop.DownHandler += game.OnDown;

eventLoop.Run();
