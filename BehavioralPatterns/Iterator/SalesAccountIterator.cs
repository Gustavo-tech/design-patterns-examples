using Iterator.Interfaces;

namespace Iterator;

internal class SalesAccountIterator : IIterator<Transaction>
{
    List<Transaction> _transactions = new();
    int Position = 0;

    internal SalesAccountIterator(List<Transaction> transactions)
    {
        _transactions = transactions;
    }

    public bool HasNext()
    {
        if (Position >= _transactions.Count)
            return false;
        else
            return true;
    }

    public Transaction Next()
    {
        Transaction transaction = _transactions[Position];
        Position++;
        return transaction;
    }
}
