namespace BowlingCalculatorTests
{
  using BowlingCalculator;

  [TestClass]
  public class BowlingGameTests
  {
    readonly BowlingGame _testGame = new([ new BowlingFrame(1, 2),
                                           new BowlingFrame(10,0),
                                           new BowlingFrame(5,3),
                                           new BowlingFrame(8,2),
                                           new BowlingFrame(2,4),
                                           new BowlingFrame(0,5),
                                           new BowlingFrame(5,0),
                                           new BowlingFrame(2,3),
                                           new BowlingFrame(0,5),
                                           new BowlingFrame(6,4,5), ]);

    [TestMethod]
    public void GameScore_ReturnsGameScore()
    {
      // Arrange
      BowlingGame game = _testGame;
      int expected = 82;

      // Act
      int actual = game.GameScore();

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FrameScore_WithValidFrame_ReturnsFrameScore()
    {
      // Arrange
      BowlingGame game = _testGame;
      int expected = 18;

      // Act
      int actual = game.FrameScore(1);

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ToString_ReturnsBowlingGameString()
    {
      // Arrange
      BowlingGame game = _testGame;
      string expected = "[1,2]|[10,0]|[5,3]|[8,2]|[2,4]|[0,5]|[5,0]|[2,3]|[0,5]|[6,4,5]";

      // Act
      string actual = game.ToString();

      // Assert
      Assert.AreEqual(expected, actual);
    }
  }
}
