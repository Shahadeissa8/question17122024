//user pass
//admin admin
//    other wrong user or pass
//    if true
//    ask for name min 3 letters
//    email the rightway
//    and age min 18

using System.ComponentModel.Design;

Console.WriteLine("Username: ");
string username = Console.ReadLine();
Console.WriteLine("Password: ");
string password = Console.ReadLine();
if (username == "admin" && password == "admin")
{
    Console.WriteLine("Enter you name: ");
    string name = Console.ReadLine() ;  
    Console.WriteLine("Enter email: ");
    string email = Console.ReadLine();
    Console.WriteLine("Enter you age: ");
    int age = Convert.ToInt32 (Console.ReadLine());
    bool check = !(email.Contains("@"));

    if (name.Length > 2 && email.Contains("@") && age > 18)
    {
        Console.WriteLine("welcome");
    }
    else if (!(name.Length > 2) && email.Contains("@") && age > 18)
    {
        Console.WriteLine("enter a valid name");
    }
    else if (name.Length > 2 && check && age > 18)
    {
        Console.WriteLine("enter a valid email");
    }
    else if (name.Length > 2 && email.Contains("@") && !(age > 18))
    {
        Console.WriteLine("enter a valid age");
    }
}
else
{
    Console.WriteLine("Worng Username or Password");
}
/* //Regex
using System.Text.RegularExpressions;

        // Regular expression pattern for validating emails
        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        // Check if the email matches the pattern
        bool isValid = Regex.IsMatch(email, pattern);
*/