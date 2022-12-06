using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests;

public class MakingWithdrawals
{
    [Fact]
    public void MakingWithdrawalsDecreasesBalance()
    {
        //Given
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToWithdrawal = 100;

        //When
        account.Withdraw(amountToWithdrawal);

        //Then
        Assert.Equal(openingBalance - amountToWithdrawal,
            account.GetBalance());
    }
}
