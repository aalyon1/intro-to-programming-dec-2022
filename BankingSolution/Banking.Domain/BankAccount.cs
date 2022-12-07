namespace Banking.Domain;
public class BankAccount
{
    private decimal _balance = 5000;
    private readonly ICalculateBonses _calculator;

    public BankAccount(ICalculateBonses calculator)
    {
        _calculator = calculator;
    }

    public void Deposit(int amountToDeposit)
    {
        // decimal bonus = _balance >= 5000M ? amountToDeposit * .10M : 0;
        decimal bonus = _calculator.GetBonusForDepositOn(_balance, amountToDeposit);
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

    public void Deposit(decimal amountToDeposit)
    {

    }
}
