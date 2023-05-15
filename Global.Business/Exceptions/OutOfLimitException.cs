namespace Global.Business.Exceptions;

public class OutOfLimitException:Exception
{
    public OutOfLimitException(string message) : base(message) { }
}
