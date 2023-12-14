namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 2));
            Console.WriteLine(Add(3.2m, 2));
            Console.WriteLine(Add(1, 0, true));

        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool z)
        {
            return z ? x + y == 1 ? $"{x + y} dollar" 
                                  : $"{x + y} dollars" 
                                  : $"{x + y}";
        }
    }
}
