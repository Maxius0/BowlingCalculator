using System.Text.RegularExpressions;

namespace BowlingCalculator
{
  public class BowlingGameReader
  {
    public BowlingGame ReadGame(string game)
    {
      string[] frameStrings = game.Split(", ");
      List<BowlingFrame> frames = [];

      foreach (string frameString in frameStrings)
      {
        BowlingFrame frame = ReadFrame(frameString);
        frames.Add(frame);
      }

      return new BowlingGame(frames);
    }

    private BowlingFrame ReadFrame(string frame) 
    {
      string[] rolls = frame.Trim(['[', ']']).Split(',');

      return new BowlingFrame(int.Parse(rolls[0]), int.Parse(rolls[1]));
    }

    public static bool IsValidGame(string game)
    {
      Regex regex = new("(\\[[0-9]+,[0-9]+\\], ){9}\\[[0-9]+,[0-9]+(,[0-9])*\\]");
      return regex.IsMatch(game);
    }
  }
}
