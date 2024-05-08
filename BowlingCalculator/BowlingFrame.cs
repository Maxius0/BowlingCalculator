namespace BowlingCalculator
{
  public class BowlingFrame
  {
    public int FirstRoll { get; set; }
    public int SecondRoll { get; set; }

    public BowlingFrame(string frame)
    {
      FromString(frame);
    }

    public int Total()
    { 
      return FirstRoll + SecondRoll;
    }

    public override string ToString()
    {
      return $"[{FirstRoll},{SecondRoll}]";
    }

    private void FromString(string frame)
    {
      string[] rolls = frame.Trim(['[', ']']).Split(',');
      FirstRoll = int.Parse(rolls[0]);
      SecondRoll = int.Parse(rolls[1]);
    }
  }
}
