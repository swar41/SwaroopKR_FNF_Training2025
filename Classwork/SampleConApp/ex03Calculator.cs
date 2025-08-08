namespace SampleConsoleApp1
{
    class ex03Calculator
    {
        static double GetVal(String q)
        {
            Console.WriteLine(q);
            return double.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                double a = GetVal("Enter first number");
                double b = GetVal("Enter second number");
                Console.WriteLine("give symbol: + - * /\n exit = ! ");
                char c = char.Parse(Console.ReadLine());
                switch (c)
                {
                    case '+': Console.WriteLine("Sum:{0}", a + b); break;
                    case '-': Console.WriteLine("Sub:{0}", a - b); break;
                    case '*': Console.WriteLine("Mul:{0}", a * b); break;
                    case '/': Console.WriteLine("Div:{0}", a / b); break;
                    case '!': return;
                    default: Console.WriteLine("Invalid"); break;
                } 
            } while (true);
           
        }
    }
}
