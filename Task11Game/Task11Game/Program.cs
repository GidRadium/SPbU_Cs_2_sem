using Task11Game;

var eventLoop = new EventLoop();
var game = new Game();

eventLoop.LeftHandler += game.OnLeft;
eventLoop.RightHandler += game.OnRight;
eventLoop.UpHandler += game.OnUp;
eventLoop.DownHandler += game.OnDown;

var log = new List<string>();
eventLoop.LeftHandler += (sender, eventArgs) => log.Add("left");
eventLoop.RightHandler += (sender, eventArgs) => log.Add("right");
eventLoop.Run();
