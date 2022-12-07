namespace Banking.Domain;
public class BankAccount
{
    private decimal _balance = 5000;
    public void Deposit(int amountToDeposit)
    {
        _balance += amountToDeposit;
    }

    public void Deposit(decimal amountToDeposit)
    {
        throw new NotImplementedException();
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public void Withdraw(int amountToWithdrawal)
    {
        _balance -= amountToWithdrawal;
    }
}
