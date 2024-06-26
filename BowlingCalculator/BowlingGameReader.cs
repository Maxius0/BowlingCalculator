﻿using System.Text.RegularExpressions;

namespace BowlingCalculator
{
  public class BowlingGameReader
  {
    public BowlingGame ReadGame(string game)
    {
      string[] frameStrings = game.Split("|");
      List<BowlingFrame> frames = [];

      foreach (string frameString in frameStrings)
      {
        BowlingFrame frame = ReadFrame(frameString);
        frames.Add(frame);
      }

      return new BowlingGame(frames);
    }

    private static BowlingFrame ReadFrame(string frame) 
    {
      string[] rolls = frame.Trim(['[', ']']).Split(',');

      if (rolls.Length > 2)
      {
        return new BowlingFrame(int.Parse(rolls[0]), int.Parse(rolls[1]), int.Parse(rolls[2]));
      }
      return new BowlingFrame(int.Parse(rolls[0]), int.Parse(rolls[1]));
    }

    public static bool IsValidGame(string game)
    {
      Regex regex = new("^(\\[(10|[0-9]),(10|[0-9])\\]\\|){9}\\[(10|[0-9]),(10|[0-9])(,(10|[0-9]))?\\]$");
      return regex.IsMatch(game);
    }
  }
}
