
namespace GutierrezFMiniChallengeEightToTen_Endpoints.Services;

public class GuessItService : IGuessItService
{
    Random random = new Random();

    // [HttpGet("easy/{number}")]
    int EasyModeRange = 10;
    int MediumModeRange = 50;
    int HardModeRange = 100;
    public string EasyMode(int number)
    {
        int guessedNumber = random.Next(1, EasyModeRange + 1);

        if (number == guessedNumber)
        {
            return "Congratulations! You guessed the number!";
        }
        else if (number < guessedNumber)
        {
            return "Too low! Try again.";
        }
        else
        {
            return "Too high! Try again.";
        }
    }

    // [HttpGet("medium/{number}")]
    public string MediumMode(int number)
    {
        int guessedNumber = random.Next(1, MediumModeRange + 1);

        if (number == guessedNumber)
        {
            return "Congratulations! You guessed the number!";
        }
        else if (number < guessedNumber)
        {
            return "Too low! Try again.";
        }
        else
        {
            return "Too high! Try again.";
        }
    }

    // [HttpGet("hard/{number}")]
    public string HardMode(int number)
    {
        int guessedNumber = random.Next(1, HardModeRange + 1);

        if (number == guessedNumber)
        {
            return "Congratulations! You guessed the number!";
        }
        else if (number < guessedNumber)
        {
            return "Too low! Try again.";
        }
        else
        {
            return "Too high! Try again.";
        }
    }
}