namespace BowlingCalculator
{
  public class BowlingGame
  {
    public List<BowlingFrame> Frames;

    public BowlingGame(List<BowlingFrame> frames)
    {
      Frames = frames;
    }

    public int GameScore()
    {
      int score = 0;

      for (int i = 0; i < Frames.Count; i++)
      {
        score += FrameScore(i);
      }

      return score;
    }

    public int FrameScore(int frameNumber)
    {
      BowlingFrame currentFrame = Frames[frameNumber];
      int score = currentFrame.FrameTotal();

      if (frameNumber == Constants.FRAMES - 1)
      {
        return score;
      }

      if (currentFrame.FrameTotal() == Constants.PINS)
      {
        BowlingFrame nextFrame = Frames[frameNumber + 1];

        score += nextFrame.FirstRoll;

        if (currentFrame.Strike())
        {
          if (nextFrame.Strike() && frameNumber < Frames.Count - 1)
          {
            score += Frames[frameNumber + 2].FirstRoll;
          }
          else
          {
            score += nextFrame.SecondRoll;
          }
        }
      }

      return score;
    }

    public override string ToString()
    {
      string bowlingGameString = "";

      for (int i = 0; i < Frames.Count; i++)
      {
        bowlingGameString += Frames[i].ToString();
      }

      return bowlingGameString;
    }
  }
}
