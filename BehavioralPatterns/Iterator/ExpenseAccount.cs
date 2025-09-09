using Iterator.Interfaces;

namespace Iterator;
internal class ExpenseAccount : IAccount
{
    private static readonly int _maxItems = 3;
    private int numberOfItems = 0;

    private Transaction[] _transactions;

    public ExpenseAccount()
    {
        _transactions = new Transaction[_maxItems];

        AddTransaction(
            name: "Gotham City Iron Works",
            amount: -1500000,
            taxRate: 10,
            isReconciled: true
        );

        AddTransaction(
            name: "Super Electronics",
            amount: -100000,
            taxRate: 20,
            isReconciled: false
        );

        AddTransaction(
            name: "Wakanda Vibranium Corporation",
            amount: -100000000,
            taxRate: 0,
            isReconciled: true
        );
    }

    public void AddTransaction(string name, float amount, float taxRate, bool isReconciled)
    {
        Transaction transaction = new(name, amount, taxRate, isReconciled);
        if (numberOfItems >= _maxItems)
        {
            Console.WriteLine("Account is full! Can't add transaction to account");
        }

        else
        {
            _transactions[numberOfItems] = transaction;
            numberOfItems += 1;
        }
    }

    public IIterator<Transaction> CreateIterator()
    {
        return new ExpenseAccountIterator(_transactions);
    }
}
