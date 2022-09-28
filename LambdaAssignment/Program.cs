namespace LambdaAssignment
{
    internal class Program
    {
        public static string firstname;
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option:\n 1.First Name ");
            int result = Convert.ToInt32(Console.ReadLine());

            switch (result)
            {
                case 1:
                    Console.WriteLine("Enter your first name ");
                    firstname = Console.ReadLine();
                    Pattern.CheckFirstName(firstname);
                    break;
            }
        }
    }
}