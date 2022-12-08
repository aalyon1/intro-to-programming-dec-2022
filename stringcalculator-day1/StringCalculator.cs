
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }

        numbers.Split(',');
        return int.Parse(numbers);
    }

}
