namespace Banking.Domain;

public interface ICalculateBonses
{
    decimal GetBonusForDepositOn(decimal currentBalance, decimal amountOfDeposit);
}