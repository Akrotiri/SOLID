namespace Solid.Banker
{
    public interface IBanker
    {
        void Deposit(string socialSecurityNumber, decimal amount);
        void Withdraw(string socialSecurityNumber, decimal amount);
    }
}