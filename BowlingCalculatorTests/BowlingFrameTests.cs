namespace BowlingCalculatorTests
{
  using BowlingCalculator;

  [TestClass]
  public class BowlingFrameTests
  {
    [TestMethod]
    public void Constructor_WithValidFrameString_SetsRollValues()
    {
      // Arrange
      string frameString = "[1,2]";
      int expectedFirstRoll = 1;
      int expectedSecondRoll = 2;

      // Act
      BowlingFrame frame = new BowlingFrame(frameString);

      // Assert
      int actualFirstRoll = frame.FirstRoll;
      int actualSecondRoll = frame.SecondRoll;
      Assert.AreEqual(expectedFirstRoll, actualFirstRoll);
      Assert.AreEqual(expectedSecondRoll, actualSecondRoll);
    }

    [TestMethod]
    public void Total_ReturnsFrameTotal()
    {
      // Arrange
      BowlingFrame frame = new BowlingFrame("[1,2]");
      int expectedTotal = 3;

      // Act
      int actualTotal = frame.Total();

      // Assert
      Assert.AreEqual(expectedTotal, actualTotal);
    }
  }
}