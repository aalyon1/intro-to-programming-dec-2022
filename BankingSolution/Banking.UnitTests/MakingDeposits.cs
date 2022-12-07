using Banking.UnitTests.TestDoubles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests;

public class MakingDeposits
{
    [Fact]
    public void MakingDepositsIncreasesBalance()
    {
        //Given
        var account = new BankAccount(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100;

        //When
        account.Deposit(amountToDeposit);

        //Then
        Assert.Equal(amountToDeposit + openingBalance,
            account.GetBalance());
    }
}
