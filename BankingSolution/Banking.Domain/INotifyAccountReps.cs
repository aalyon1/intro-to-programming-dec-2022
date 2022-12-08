namespace Banking.Domain;

public interface INotifyAccountReps
{
    void NotifyOfAttemptedOverdraft(BankAccount bankAccount, decimal balance, int amountToWithdrawal);
}