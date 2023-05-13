namespace Global.Business.Exceptions;

public class CapacityNotEnoughException:Exception
{
    public CapacityNotEnoughException(string message) : base(message) { }
}
