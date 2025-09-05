namespace Iterator.Interfaces;
internal interface IIterator<T>
{
    bool HasNext();
    T Next();
}
