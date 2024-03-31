namespace uwu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rusername = "Admin";
            string rpassword = "Admin1234!";
            int attempts = 0;
            while (attempts < 3) 
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();

                if (rusername == username && rpassword == password)
                { 
                    Console.WriteLine("Login Successful!");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect Credentials. Please try again.");
                    attempts++;
                }
            }
            Console.WriteLine("Maximum login attempts exceeded.");
            
            
        }
    }
}
