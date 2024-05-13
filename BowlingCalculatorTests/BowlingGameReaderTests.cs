namespace BowlingCalculatorTests
{
  using BowlingCalculator;

  [TestClass]
  public class BowlingGameReaderTests
  {
    [TestMethod]
    public void ReadGame_ReturnsValidBowlingGame()
    {
      // Arrange
      string bowlingGameString = "[7,1], [0,0], [6,2], [0,5], [4,4], [4,0], [7,2], [3,2], [5,5], [1,6]";
      int[] expectedFirstRolls = [7, 0, 6, 0, 4, 4, 7, 3, 5, 1];
      int[] expectedSecondRolls = [1, 0, 2, 5, 4, 0, 2, 2, 5, 6];

      // Act
      BowlingGame bowlingGame = new BowlingGameReader().ReadGame(bowlingGameString);

      // Assert
      var frames = bowlingGame.Frames;
      for (int i = 0; i < frames.Count; i++)
      {
        Assert.AreEqual(expectedFirstRolls[i], frames[i].FirstRoll);
        Assert.AreEqual(expectedSecondRolls[i], frames[i].SecondRoll);
      }
    }

    [TestMethod]
    public void IsValidGame_WithValidGame_ReturnsTrue()
    {
      // Arrange
      string bowlingGameString = "[7,1], [0,0], [6,2], [0,5], [4,4], [4,0], [7,2], [3,2], [5,5], [1,6]";

      // Act
      bool actual = BowlingGameReader.IsValidGame(bowlingGameString);

      // Assert
      Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsValidGame_WithInValidGame_ReturnsFalse()
    {
      // Arrange
      string bowlingGameString = "[7,1], [0,0], [6,2], [0,x], [4,4], [4,0], [7,2], [3,2], [5,5], [1,6]";

      // Act
      bool actual = BowlingGameReader.IsValidGame(bowlingGameString);

      // Assert
      Assert.IsFalse(actual);
    }
  }
}