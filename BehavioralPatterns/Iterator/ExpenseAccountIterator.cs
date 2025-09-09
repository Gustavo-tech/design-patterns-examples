using Iterator.Interfaces;

namespace Iterator;
internal class ExpenseAccountIterator(Transaction[] transactions) : IIterator<Transaction>
{
    Transaction[] _transactions = transactions;
    int position = 0;

    public Transaction Next()
    {
        Transaction transaction = _transactions[position];
        position += 1;
        return transaction;
    }

    public bool HasNext()
    {
        if (position >= _transactions.Length || _transactions[position] == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
