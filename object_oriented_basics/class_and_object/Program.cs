//creating an object from person class..

Person person1 = new Person();

//initializing instance variables of person class..
person1.firstName = "Rayhan";
person1.middleName = "Mahmud";
person1.lastName = "Kabir";

//calling the GetFullName method of person class..
Console.WriteLine(person1.GetFullName());

//primitive data types e.g(int,float,double..) are value type..string is a exception..string is reference type..
int a = 100;
int b = a;
a = 200;

Console.WriteLine(b); /*output will be 100..as int is a value type and changing the value of a doesn't change the
                      value of b..*/

//Non primitive data types e.g(class,objects) are reference types..

Person person2 = new Person();

person2.firstName = "Mohammad";
person2.middleName = "Abdul";
person2.lastName = "Kadir";

Console.WriteLine(person2.GetFullName());

Person person3 = new Person();
person3 = person2;             //Here person3 is referencing person2..person3 will have all the values of person2..
Console.WriteLine(person3.GetFullName()); //output will be Mohammad Abdul Kadir..

person3.middleName = person1.middleName;  //It will also change the middleName of person2..

Console.WriteLine(person2.GetFullName()); //output will be Mohammad Mahmud Kabir..As objects are reference types,
                                          //changing value in one object will change the value in referring object..
person2 = null;
Console.WriteLine(person2.GetFullName());  /*this line will throw error because the memory address stored in person2
                                           is now null..Making an object null doesn't mean deleting that object from memory*/

Console.WriteLine(person3.GetFullName());  /*but person3 still stores the same memory address as person2 and
                                             that's why printing person3 fullname won't generate any error..because
                                             the object person2 isn'i deleted from memory..*/
