public class Information
{
    //There are four types of access modifiers e.g(public,internal,protected,private)
    //these are used to access data/field/instance variables..

    public string name;
    private int phoneNumber;
    private string email;
    private string password;
    private string address;

    /*public field can be accessed by anyone and can be changed by anyone..Doesn't need any method
      or constructor to access public field..*/

    //method for accessing phone number..
    public void SetphoneNumber(int phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }
    public int GetphoneNumber()
    {
        return phoneNumber;
    }

    //method for accessing email field..
    public void SetEmail(string email)
    {
        this.email = email;
    }
    public string GetEmail()
    {
        return email;
    }

    //method for accessing password field..
    public void SetPassword(string password)
    {
        this.password = password;
    }
    public string GetPassword()
    {
        return password;
    }

    public string GetAddress()
    {
        return address;
    }
}