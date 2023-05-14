namespace Global.Business.Helpers;

public static class Helper
{
    public static Dictionary<string, string> Errors = new Dictionary<string, string>()
    {
        {"AlreadyExistException","This object already exists"},
        {"SizeException","Length doesn't match"},
        {"NotValidWordException","Entered word is not valid.Please use only letters" },
        {"CapacityNotEnoughException","Group is full"},
        {"NotValidNumberException","Entered id doesn't exist"}
    };
}
