using HelloLib;

namespace HelloWorld
{    
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:...");
            string? name = Console.ReadLine();

            HelloPrinter printer = new HelloPrinter();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Please write something bro...");
            }

            printer.SayHello(name);
        }
    }
}