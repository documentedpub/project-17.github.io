string permission = "Admin | Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    if (level > 55)
        System.Console.WriteLine("Welcome, Super Admin user.");
    if (level <= 55)
        System.Console.WriteLine("Welcome, Admin user.");
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    System.Console.WriteLine("Contact an Admin for access.");
    if (level < 20)
    System.Console.WriteLine("You do not have sufficient privileges.");
}
else
System.Console.WriteLine("You do not have sufficient privileges.");
