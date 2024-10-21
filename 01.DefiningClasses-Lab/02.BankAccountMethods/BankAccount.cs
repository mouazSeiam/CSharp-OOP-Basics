public class BankAccount
{
    private int id;
    private decimal balance;

    public decimal Balance { get; set;}

    public int Id { get; set;}

    public void Deposit(decimal amount) => Balance += amount;

    public void Withdraw(decimal amount) => Balance -= amount;
     
    public override string ToString() => $"Acount{Id}, balance {Balance}";
}
