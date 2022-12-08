using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests;

public class GoldAccountBenefits
{
    [Fact]
    public void GetBonusOnDeposit()
    {
        var stubbedBonusCalculator = new Mock<ICalculateBonses>();
        var account = new BankAccount(stubbedBonusCalculator.Object);
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;
        var expectedBonus = 10M;


        account.Deposit(amountToDeposit);


        Assert.Equal(openingBalance + amountToDeposit + expectedBonus,
             account.GetBalance());



    }
}