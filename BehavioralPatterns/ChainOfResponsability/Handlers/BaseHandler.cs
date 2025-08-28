namespace ChainOfResponsability.Handlers;

internal abstract class BaseHandler
{
    private BaseHandler? _next;

    internal BaseHandler SetNext(BaseHandler next)
    {
        _next = next;
        return next;
    }

    internal abstract bool Handle(string username, string password);

    protected bool HandleNext(string username, string password)
    {
        if (_next == null)
        {
            return true;
        }

        return _next.Handle(username, password);
    }
}
