namespace TESTFORGITHUB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, GitHub!");

            PrintHello("SUP");

            newPush("HELLO");
        }

        static void PrintHello(string hello)
        {
            Console.WriteLine(hello);
        }

        static void newPush(string new)
        {
            Console.WriteLine(new);
        }
    }
}
