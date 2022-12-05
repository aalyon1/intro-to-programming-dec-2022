using HelloWorld;

Console.WriteLine("Take a break!");

Console.Write("How many mins? :");
string? minutes = Console.ReadLine();

if (minutes is not null)
{
    DateUtils utils = new DateUtils();
    int mins = int.Parse(minutes);
    DateTime timeAtEndOfBreak = utils.TakeABreak(mins);
    Console.WriteLine($"Okay, be back at {timeAtEndOfBreak:T}");
}
else
{
    Console.WriteLine("Enter some mins");
}