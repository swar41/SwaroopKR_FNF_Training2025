namespace SampleConsoleApp1
{
    /*
 * Enums are User Defined Data Types(UDTs) that are used to define Named Constants. If U have a set of related constants, you can use an enum to define them in a single type.
 * All Enum values are internally of type int, but you can specify a different underlying type if needed and it should be integral type only.
 * 
 */
    enum Days
    {
        Monday=1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    internal class exTypeCasting
    {

        static void Main(string[] args)
        {
            //int a = 123;
            ////long al=(long)a;  //explicit conversion..if casting doesnt happens , it doesnt throws the exception,but stores garbage value
            //long al = Convert.ToInt64(a);//convert class does conversion and throws the exception unlike above approach
            //Console.WriteLine(al);

            string dayInput = Console.ReadLine();
            Days day = Enum.Parse<Days>(dayInput); // true for case-insensitive parsing
            Console.WriteLine("The selected day is " + day + " number: " + (int)day + "DATA TYPE: " + day.GetTypeCode());
            Console.WriteLine("Get all days ");
            Array val=Enum.GetValues(typeof(Days));
            foreach(var v in val) Console.WriteLine(v);

        }
    }
}