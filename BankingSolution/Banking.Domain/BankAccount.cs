namespace Banking.Domain;
public class BankAccount
{
    private decimal _balance = 5000;
    public virtual void Deposit(int amountToDeposit)
    {
        _balance += amountToDeposit;
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
