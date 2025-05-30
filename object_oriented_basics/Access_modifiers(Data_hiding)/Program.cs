Information myInformation = new Information();

//we can access name field form here as it is set to public..
myInformation.name = "Kabir";
Console.WriteLine(myInformation.name);

/*as phoneNumber is a private field it can only be accesed by method/constructor.
 here we are accessing phoneNumber through SetphoneNumber and GetphoneNumber methods.*/
myInformation.SetphoneNumber(45412);
Console.WriteLine(myInformation.GetphoneNumber());

/*as email is a private field it can only be accesed by method/constructor.
 here we are accessing email through SetEmail and GetEmail methods.*/
myInformation.SetEmail("hhjd@gmail.com");
Console.WriteLine(myInformation.GetEmail());

/*as password is a private field it can only be accesed by method/constructor.
 here we are accessing password through SetPassword and GetPassword methods.*/
myInformation.SetPassword("dhhd%67");
Console.WriteLine(myInformation.GetPassword());

Console.WriteLine(myInformation.GetAddress());
