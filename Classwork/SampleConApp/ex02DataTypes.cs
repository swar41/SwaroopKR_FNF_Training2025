namespace SampleConsoleApp1
{
    class ex02DataTypes
    {   /* all datatypes in c# are based on CTS(Common type System) fo .NET Framework and provides
            common set of data types for all languages
         * classified into primitive types(struct) and refernce types(classes)
         * Primitive /known types are data types that r common among all languages:also called value types
         * integral types(byte - 2 bits, short - 16 bit, int - 32 bit, long - 64 bit)
         */

        static void Main(string[] args)
        {
            int age = 123;
            float fage = 123.23f;
            double dage = 123.4321;
            char c = 'A';
            Console.WriteLine("age: {0}, fage:{1}, dage:{2}, char:{3}, {2} is greater than {1}", age, fage, dage, c);
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine("my phone number :" + num);

            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("my weight:" + weight);
        }

    }
}