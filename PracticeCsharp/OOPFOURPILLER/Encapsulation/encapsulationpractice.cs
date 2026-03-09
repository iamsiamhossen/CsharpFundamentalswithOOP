BankAccount Siamaccount = new BankAccount("Siam Hossen", 18000.90);
Siamaccount.PrintAccountInfo();
Siamaccount.Deposit(589.50);
Siamaccount.withdraw(2000);
public class BankAccount
{
    // eta holo auto-implemented property,
    // jeta amader code ke aro clean and readable kore,
    public string AccountHolder { get; private set; }
    // eta holo private field, jeta amader class er vitore use hobe, 
    // and seta directly access kora jabe na class er bahire, mane encapsulation er principle follow kore.
    private double Balance;

    // eta holo constructor, 
    // jeta amader class er object create korar somoy call hobe, a
    // nd seta amader account holder er name and initial balance set korbe.
    public BankAccount(string accountHolder, double initialBalance)
    {
        AccountHolder = accountHolder;
        Balance = initialBalance;
    }
    // eta holo method, jeta amader account holder er name change korar jonno use hobe,
    // and seta parameter hishebe new account holder er name nibe, and seta set
    // korbe AccountHolder property te, and seta amader account holder er name change korbe.
    public void changeAccountHolder(string newAccountHolder)
    {
        AccountHolder = newAccountHolder;
    }
    // eta holo method, jeta amader account er balance read korar jonno use hobe, 
    // and seta return korbe account er balance ta.
    public double GetBalance()
    {
        return Balance;
    }
    public void PrintAccountInfo()
    {
        Console.WriteLine($"Account Holder:{AccountHolder},Balance: {Balance}");
    }
    // eta holo method, jeta amader account e taka deposit korar jonno use hobe,
    // and seta parameter hishebe deposit amount nibe, and seta balance e add korbe, 
    // and seta console e print korbe deposit amount and new balance ta, 
    // but amra check korbo jodi deposit amount ta positive hoy, 
    // taholei seta deposit hobe, otherwise seta deposit hobe na.
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount} taka. New Balance: {Balance} taka");

        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }
    // eta holo method, jeta amader account theke taka withdraw korar jonno use hobe,
    // and seta parameter hishebe withdraw amount nibe, and seta balance theke subtract korbe, 
    // and seta console e print korbe withdraw amount and new balance ta, 
    // but amra check korbo jodi withdraw amount ta positive hoy and balance er theke kom hoy, 
    // taholei seta withdraw hobe, otherwise seta withdraw hobe na.
    public void withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount} taka. New Balance: {Balance} taka");
        }
        else
        {
            Console.WriteLine("Invalid withdraw amount. Must be positive and less than or equal to balance.");
        }
    }

}
