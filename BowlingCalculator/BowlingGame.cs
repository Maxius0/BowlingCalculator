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
      BowlingFrame nextFrame = Frames[frameNumber + 1];
      int score = currentFrame.FrameTotal();

      if (frameNumber == 10)
      {
        return score;
      }

      if (currentFrame.Spare())
      {
        score += nextFrame.FirstRoll;
      }

      if (currentFrame.Strike())
      {
        score += nextFrame.FirstRoll;

        if (nextFrame.Strike() && frameNumber < 9)
        {
          score += Frames[frameNumber + 2].FirstRoll;
        }
        else
        {
          score += nextFrame.SecondRoll;
        }
      }

      return score;
    }
  }
}
