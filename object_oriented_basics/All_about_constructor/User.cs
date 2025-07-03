public class User
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }

    //This is a constructor..Constructor name must be same as the class name..
    //public User(string firstName,string middleName,string lastName)
    //{
    //    FirstName = firstName;
    //    MiddleName = middleName;
    //    LastName = lastName;
    //}

    public string UserName()
    {
        string fullName = FirstName + " " + MiddleName + " " + LastName;
        return fullName;
    }

}
