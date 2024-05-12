namespace BowlingCalculatorTests
{
  using BowlingCalculator;
  using NuGet.Frameworks;

  [TestClass]
  public class BowlingFrameTests
  {
    [TestMethod]
    public void Total_ReturnsFrameTotal()
    {
      // Arrange
      BowlingFrame frame = new BowlingFrame(1, 2);
      int expected = 3;

      // Act
      int actual = frame.FrameTotal();

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ToString_ReturnsBowlingGameString()
    {
      // Arrange
      BowlingFrame frame = new BowlingFrame(1, 2, 3);
      string expected = "[1,2,3]";

      // Act
      string actual = frame.ToString();

      // Assert
      Assert.AreEqual(expected, actual);
    }
  }
}