namespace LambdaAssignment
{
    internal class Program
    {
        public static string firstname,lastname,email,mobileNumber1,password;
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option:\n 1.First Name \n 2.Last name \n 3.Enter email \n 4.Enter the number \n 5.Enter the password");
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
                case 4:
                    Console.WriteLine("Enter the phone number");
                    mobileNumber1 = Console.ReadLine();
                    Pattern.CheckMobileNumber(mobileNumber1);
                    break;
                case 5:
                    Console.WriteLine("Enter the password");
                    password = Console.ReadLine();
                    Pattern.CheckPassword(password);
                    break;



            }
        }
    }
}