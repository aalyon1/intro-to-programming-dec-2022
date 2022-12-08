using Banking.UnitTests;
using Moq;
using Banking.Domain;

namespace Banking.UnitTests;

public class OverdraftOfAccount
{
    private readonly BankAccount account;

    public OverdraftOfAccount()
    {
        account = new BankAccount(new Mock<ICalculateBonses>().Object,
            new Mock<INotifyAccountReps>.Object);
    }

    [Fact] // Safety Net - an "Invariant"
    public void CanTakeAllTheMoney()
    {
        var account = new BankAccount(new Mock<ICalculateBonses>().Object);

        account.Withdraw(account.GetBalance());

        Assert.Equal(0, account.GetBalance());
    }

    [Fact]
    public void OverdraftDoesNotDecreaseTheBalance()
    {
        var account = new BankAccount(new Mock<ICalculateBonses>().Object);
        var openingBalance = account.GetBalance();
        var amountToWithDraw = openingBalance + .01M;

        // Exceptional Behavior
        try
        {
            account.Withdraw(amountToWithDraw); //  "No-op"
        }
        catch (OverdraftException)
        {

            // Ignore it.
        }

        Assert.Equal(openingBalance, account.GetBalance());
    }

    [Fact]
    public void OverdraftThrowsAnOverdraftException()
    {
        var account = new BankAccount(new Mock<ICalculateBonses>().Object);

        Assert.Throws<OverdraftException>(() =>
        {
            account.Withdraw(account.GetBalance() + .51M);
        });
    }
}