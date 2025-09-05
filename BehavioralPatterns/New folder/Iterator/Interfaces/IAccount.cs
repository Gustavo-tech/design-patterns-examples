namespace Iterator.Interfaces;
internal interface IAccount
{
    void AddTransaction(string name, float amount, float taxRate, bool isReconciled);
    IIterator<Transaction> CreateIterator();
}
