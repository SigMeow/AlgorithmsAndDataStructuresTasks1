public class Country
{
    public int Id; public string Name; public string Continent;
}
public class Manager
{
    public int Id; public string FullName; public int Experience;
}
public class Tour
{
    public int Id; public string Name; public int CountryId; public int ManagerId; public decimal Price; public int Days;
}
