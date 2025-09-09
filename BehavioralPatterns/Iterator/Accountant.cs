using Iterator.Interfaces;

namespace Iterator;

internal class Accountant
{
    private readonly IAccount _expenseAccount;
    private readonly IAccount _salesAccount;

    internal Accountant(IAccount expenseAccount, IAccount salesAccount)
    {
        _expenseAccount = expenseAccount;
        _salesAccount = salesAccount;
    }

    internal void PrintTransactions()
    {
        IIterator<Transaction> salesIterator = _salesAccount.CreateIterator();
        IIterator<Transaction> expensesIterator = _expenseAccount.CreateIterator();

        Console.WriteLine("ACCOUNT\n----\nSALES");
        PrintTransactions(salesIterator);
        Console.WriteLine("\nEXPENSES");
        PrintTransactions(expensesIterator);
    }

    private static void PrintTransactions(IIterator<Transaction> iterator)
    {
        while (iterator.HasNext())
        {
            Transaction transaction = iterator.Next();
            Console.WriteLine($"{transaction.Name}\n{transaction.Amount}\n{transaction.TaxRate}\n{transaction.IsReconciled}");
            Console.WriteLine();
        }
    }
}
