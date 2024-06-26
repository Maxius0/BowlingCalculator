﻿namespace BowlingCalculator
{
  public static class BowlingCalculatorUI
  {
    const string _exampleGame = "[7,1]|[0,0]|[6,2]|[0,5]|[4,4]|[4,0]|[7,2]|[3,2]|[5,5]|[1,6]";
    const string _headers = "Frame: [ 1 ]|[ 2 ]|[ 3 ]|[ 4 ]|[ 5 ]|[ 6 ]|[ 7 ]|[ 8 ]|[ 9 ]|[ 10]";

    public static void Start()
    {
      Console.WriteLine("Welcome to the bowling calculator!");
      
      string? input;

      while (true)
      {
        Console.WriteLine("Please enter a valid bowling game to get started. (Or \"ex\" to get an example; \"q\" to quit.)");
        input = Console.ReadLine();

        switch (input)
        {
          case null:
            continue;
          case "q":
            Environment.Exit(0);
            break;
          case "ex":
            Console.WriteLine("Example game:");
            Console.WriteLine(_exampleGame);
            break;
          case string when BowlingGameReader.IsValidGame(input):
            Calculator(input);
            break;
          default:
            Console.WriteLine("Invalid input.");
            break;
        }
      }
    }

    private static void Calculator(string bowlingGameString)
    {
      BowlingGameReader bowlingGameReader = new();
      BowlingGame bowlingGame = bowlingGameReader.ReadGame(bowlingGameString);

      Console.WriteLine("Your game:");
      Console.WriteLine(_headers);
      Console.WriteLine("Pins:  " + bowlingGame);

      string? input;

      while (true)
      {
        Console.WriteLine("Enter \"t\" to see total score; frame# (1-10) to see score for that frame; \"all\" to see score for every frame; \"r\" to restart; or \"q\" to quit.");

        input = Console.ReadLine();

        switch (input)
        {
          case null:
            continue;
          case "q":
            Environment.Exit(0);
            break;
          case "r":
            return;
          case "t":
            Console.WriteLine("Total score for this game: " + bowlingGame.GameScore());
            break;
          case string when int.TryParse(input, out int frameNumber) && frameNumber <= Constants.FRAMES && frameNumber > 0:
            Console.WriteLine($"Score for round {frameNumber}: {bowlingGame.FrameScore(frameNumber-1)}");
            break;
          case "all":
            string frameScores = "";
            
            for (int i = 0; i < Constants.FRAMES; i++)
            {
              frameScores += "[ " + bowlingGame.FrameScore(i);
              if (bowlingGame.FrameScore(i) < 10)
              {
                frameScores += " ";
              }
              frameScores += "]";
              if (i < Constants.FRAMES - 1)
              {
                frameScores += "|";
              }
            }

            Console.WriteLine(_headers);
            Console.WriteLine("Score: " + frameScores);
            Console.WriteLine("Total: " + bowlingGame.GameScore());
            break;
          default:
            Console.WriteLine("Invalid input.");
            break;
        }
      }
    }
  }
}
