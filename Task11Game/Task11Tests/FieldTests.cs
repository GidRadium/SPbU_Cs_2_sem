using Task11Game;
namespace Task11Tests;

public class FieldTests
{
    private Field field;

    [SetUp]
    public void Setup()
    {
        field = new Field("..\\..\\..\\TestFields\\TestField.txt");
    }

    [Test]
    public void PlayerCanStepIntoEmptyCell()
    {
        var coordBeforeMove = field.PlayerPosition;
        field.TryToMovePlayer((1, 0));
        var coordAfterMove = field.PlayerPosition;
        Assert.That((coordAfterMove.x - coordBeforeMove.x, coordAfterMove.y - coordBeforeMove.y), Is.EqualTo((1, 0)));
    }

    [Test]
    public void PlayerCantStepIntoWallCell()
    {
        field.TryToMovePlayer((1, 0));
        var coordBeforeMove = field.PlayerPosition;
        field.TryToMovePlayer((1, 0));
        var coordAfterMove = field.PlayerPosition;
        Assert.That(coordAfterMove, Is.EqualTo(coordBeforeMove));
    }

    [Test]
    public void PlayerCanJumpThroughField()
    {
        var coordBeforeMove = field.PlayerPosition;
        field.TryToMovePlayer((0, 1));
        field.TryToMovePlayer((0, 1));
        field.TryToMovePlayer((0, 1));
        field.TryToMovePlayer((0, 1));
        field.TryToMovePlayer((0, 1));
        field.TryToMovePlayer((0, 1));
        field.TryToMovePlayer((0, 1));
        var coordAfterMove = field.PlayerPosition;
        Assert.That(coordAfterMove, Is.EqualTo(coordBeforeMove));
    }
}
