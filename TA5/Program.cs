Console.WriteLine("Enter file name");
var fileName = Console.ReadLine();
if (fileName == "person1")
{
    Console.WriteLine($"{Environment.NewLine}{fileName} located. Please enter the following information");
    Console.WriteLine("First Name:");
    var firstName = Console.ReadLine();
    Console.WriteLine("Last Name:");
    var lastName = Console.ReadLine();
    Console.WriteLine("Email Address:");
    var emailAddress = Console.ReadLine();
    if ((firstName == "Tyler") & (lastName == "Hogue") & (emailAddress == "testemail.com"))
    {
        Console.WriteLine($"{Environment.NewLine}{firstName} {lastName} @{emailAddress}");
        Console.WriteLine($"{Environment.NewLine}{fileName} has been verified. Press any key to exit");
        Console.ReadKey(true);
    }
    else
    {
        Console.WriteLine($"{Environment.NewLine}{fileName} information entered is incorrect. To try again, press any key to exit");
        Console.ReadKey(true);
    }
}
else
{
    Console.WriteLine($"{Environment.NewLine}{fileName} could not be found. To try again, press any key to exit");
    Console.ReadKey(true);
}

