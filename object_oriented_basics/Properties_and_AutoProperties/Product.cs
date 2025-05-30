public class Product
{
    //properties and autoproperties are special types of methods which acts like a field/instance variable.
    private string productName;
    private int productPrice;

    public string ProductId { get; set; } //Auto property..

    /*Name of a property always starts with capital letter.A field/instance variable of same name must be declared first
      and the field/instance variable must be private..*/
    public string ProductName
    {
        set
        {
            productName = value;  //value stores the parameter that is passed from the object..
        }
        get
        {
            return productName;
        }
    }

    public int ProductPrice
    {
        set
        {
            productPrice = value;
        }
        get
        {
            return productPrice;
        }
    }

}
