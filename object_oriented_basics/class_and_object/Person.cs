using System.Net.Http.Json;

public class Person
{
    //Class fields or instance variables..
    public string firstName;
    public string middleName;
    public string lastName;

    //public method..
    public string GetFullName()
    {
        string fullName = firstName + " " +middleName + " " +lastName;
        return fullName;
    }
}
