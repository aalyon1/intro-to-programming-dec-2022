using Banking.Domain;

namespace Banking.UnitTests.TestDoubles;



// Canned responses to questions.
public class StubbedBonusCalculator : ICalculateBonses
{
    public decimal GetBonusForDepositOn(decimal currentBalance, decimal amountOfDeposit)
    {
        return currentBalance == 5000M && amountOfDeposit == 92.42M ? 42 : 0;
    }
}