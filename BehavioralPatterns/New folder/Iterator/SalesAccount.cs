using Iterator.Interfaces;

namespace Iterator;
internal class SalesAccount : IAccount
{
    private List<Transaction> _transactions = new();

    internal SalesAccount()
    {
        AddTransaction(
            name: "Stark Industries",
            amount: 200000000,
            taxRate: 0,
            isReconciled: false
        );

        AddTransaction(
            name: "Wayne Enterprises",
            amount: 5500000,
            taxRate: 10,
            isReconciled: true
        );

        AddTransaction(
            name: "Oscorp",
            amount: 100000,
            taxRate: 20,
            isReconciled: false
        );
    }

    public void AddTransaction(string name, float amount, float taxRate, bool isReconciled)
    {
        Transaction transaction = new Transaction(name, amount, taxRate, isReconciled);
        _transactions.Add(transaction);
    }

    public IIterator<Transaction> CreateIterator()
    {
        return new SalesAccountIterator(_transactions);
    }
}
