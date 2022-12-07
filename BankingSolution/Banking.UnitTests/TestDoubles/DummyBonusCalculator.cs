
namespace Banking.UnitTests.TestDoubles;

public class DummyBonusCalculator : ICalculateBonses
{
    public decimal GetBonusForDepositOn(decimal currentBalance, decimal amountOfDeposit)
    {
        return 0;
    }
}
