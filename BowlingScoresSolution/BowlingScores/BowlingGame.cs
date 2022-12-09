
namespace BowlingScores;

public class BowlingGame
{
    private readonly List<BowlingGameRecord> _games = new();
    public void AddPlayerScore(BowlingGameRecord score)
    {
        _games.Add(score);
    }
}
