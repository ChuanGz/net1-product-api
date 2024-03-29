using System.Reflection.Metadata.Ecma335;

public static class BuilderService
{
    public static string ReturnName()
    {
        return "Kendy";
    }

    public static string ReturnName(Employee employee)
    {
        return employee.Name;
    }
}
