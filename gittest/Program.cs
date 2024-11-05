namespace gittest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            koszonto();
            Console.WriteLine(Osszeadas(10, 90));
            Console.ReadLine();
        }

        static void koszonto()
        {
            Console.WriteLine("Hello világ");
        }

        static int Osszeadas(int a, int b)
        {
            // int osszeg = a + b;
            // return osszeg;

            return a + b;
        }
    }
}
