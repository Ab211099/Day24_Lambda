namespace LambdaAssignment
{
    internal class Program
    {
        public static string firstname,lastname,email;
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option:\n 1.First Name \n 2.Last name \n 3.Enter email");
            int result = Convert.ToInt32(Console.ReadLine());

            switch (result)
            {
                case 1:
                    Console.WriteLine("Enter your first name ");
                    firstname = Console.ReadLine();
                    Pattern.CheckFirstName(firstname);
                    break;
                case 2:
                    Console.WriteLine("Enter your last name");
                    lastname = Console.ReadLine();
                    Pattern.CheckLastName(lastname);
                    break;
                case 3:
                    Console.WriteLine("Enter the mail");
                    email = Console.ReadLine();
                    Pattern.CheckEmail(email);
                    break;
                    

            }
        }
    }
}