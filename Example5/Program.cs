Console.WriteLine("Add user name");
string username = Console.ReadLine();

if(username.ToLower() == "yulia")
{
    Console.WriteLine("Wow, it's Yulia!");
}
else
{
    Console.Write("Hey, ");
    Console.WriteLine(username);
}