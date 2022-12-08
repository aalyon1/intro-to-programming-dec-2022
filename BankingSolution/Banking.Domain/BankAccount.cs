namespace Banking.Domain;
public class BankAccount
{
    private decimal _balance = 5000;
    private readonly ICalculateBonses _calculator;
    private readonly INotifyAccountReps _accountRepNotifier;

    public BankAccount(ICalculateBonses calculator, INotifyAccountReps accountRepNotifier)
    {
        _calculator = calculator;
        _accountRepNotifier = accountRepNotifier;
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
        if (amountToWithdrawal > _balance)
        {
            _accountRepNotifier.NotifyOfAttemptedOverdraft(this, _balance, amountToWithdrawal);
            throw new OverdraftException();
        }
        _balance -= amountToWithdrawal;
    }

    public void Deposit(decimal amountToDeposit)
    {

    }

    public void Withdraw(decimal v)
    {
        throw new NotImplementedException();
    }
}
