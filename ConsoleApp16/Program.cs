using ConsoleApp16;

internal class Program
{
    private static void Main(string[] args)
    {
        user[] users = new user[]
            {
        new user {Name="Ali", SurName="Aliyev", UserName= "ali_aliyev", Password="12345"},
        new user {Name="Ahmad", SurName="Ahmadov", UserName= "ahmad_ahmadov", Password="12345ahmad"},

            };
        student[] students = new student[]
        {
        new student {Name="Ahmad", SurName="Ahmadov", UserName= "ahmad_ahmadov", Password="12345ahmad",Grade=100 },
        new student {Name= "Orxan", SurName="Aslanov", UserName="orxan_aslanov", Password="12345orxan", Grade=90 },
            };


        Console.WriteLine("Username:");
        string username = Console.ReadLine();
        Console.WriteLine("Password:");
        string password = Console.ReadLine();

        user enteruser = new user();
        foreach (var user1 in users)
        {
            if (user1.UserName == username && user1.Password == password)
            {
                enteruser = user1;
                break;
            }

        }

        foreach (var user1 in students)
        {
            if (user1.UserName == enteruser.UserName)
            {
                Console.WriteLine(user1.Grade);
            }
        }
    }
}