Console.WriteLine("Bowling Score Tool!");

// Ask in loop for name and score of each player
// A blank lines means we are done adding players
Console.WriteLine("Enter your bowlers name. If you are done, press Enter");
var game = new List<BowlingGameRecord>();

while(true)
{
    Console.WriteLine("Enter the name of the bowler: ");
    var name = Console.ReadLine();
    if (name == "")
    {
        break;
    }
    Console.WriteLine($"What was {name}'s Score? :");
    var score = int.Parse( Console.ReadLine() );
    game.Add(new BowlingGameRecord(name, score));

}

foreach (var g in game)
{
    Console.WriteLine($"Bowler {g.player} got a score of {g.score}");
}
public record BowlingGameRecord(string player, int score);
