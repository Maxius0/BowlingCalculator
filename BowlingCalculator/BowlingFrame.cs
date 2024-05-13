namespace BowlingCalculator
{
  public class BowlingFrame
  {
    public int FirstRoll { get; set; }
    public int SecondRoll { get; set; }
    public int? ThirdRoll { get; set; }

    public BowlingFrame(int firstRoll, int secondRoll)
    {
      FirstRoll = firstRoll;
      SecondRoll = secondRoll;
    }

    public BowlingFrame(int firstRoll, int secondRoll, int thirdRoll)
    {
      FirstRoll = firstRoll;
      SecondRoll = secondRoll;
      ThirdRoll = thirdRoll;
    }

    public int FrameTotal()
    { 
      return FirstRoll + SecondRoll + (ThirdRoll ?? 0);
    }

    public bool Strike()
    {
      return FirstRoll == 10;
    }

    public override string ToString()
    {
      return $"[{FirstRoll},{SecondRoll}" + (ThirdRoll is null ? "" : $",{ThirdRoll}") + "]";
    }
  }
}
