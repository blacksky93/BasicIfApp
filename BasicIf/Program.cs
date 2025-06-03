namespace BasicIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name: ");
            string? firstName = Console.ReadLine();

            if (firstName.ToLower() == "tim")
            {
                Console.WriteLine("Hell Mr. Corey");
            }
            else
            {
                Console.WriteLine($"Hello {firstName}");
            }
            Console.WriteLine("End of Program.");
        }
    }
}
