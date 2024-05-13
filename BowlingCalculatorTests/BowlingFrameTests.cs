namespace BowlingCalculatorTests
{
  using BowlingCalculator;

  [TestClass]
  public class BowlingFrameTests
  {
    [TestMethod]
    public void FrameTotal_ReturnsFrameTotal()
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
    public void Strike_WithStrike_ReturnsTrue()
    {
      // Arrange
      BowlingFrame frame = new BowlingFrame(10, 0);

      // Act
      bool actual = frame.Strike();

      // Assert
      Assert.IsTrue(actual);
    }

    [TestMethod]
    public void Strike_WithSpare_ReturnsFalse()
    {
      // Arrange
      BowlingFrame frame = new BowlingFrame(5, 5);

      // Act
      bool actual = frame.Strike();

      // Assert
      Assert.IsFalse(actual);
    }

    [TestMethod]
    public void ToString_ReturnsBowlingFrameString()
    {
      // Arrange
      BowlingFrame frame = new BowlingFrame(1, 2);
      string expected = "[1,2]";

      // Act
      string actual = frame.ToString();

      // Assert
      Assert.AreEqual(expected, actual);
    }
  }
}