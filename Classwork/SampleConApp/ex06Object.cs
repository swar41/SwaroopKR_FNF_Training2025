namespace SampleConsoleApp1
{
    internal class ex06Object
    {
          /*
          * Object is the universal/base class for all data types in C#.
          * All types, whether they are built-in types or user-defined types, derive from Object.
          * boxing and unboxing are concepts related to Object class.Boxing is the process of converting a value type to an object type, while unboxing is the reverse process.
          * u cant cast object to value type directly, it needs to be unboxed first.
          */
        static void Main(string[] args)
        {
            object obj = 123; // Boxing: int to object
            /// <summary>
            /// Demonstrates boxing and unboxing in C# using the object type.
            /// Shows how a value type (int) is boxed into an object, how to unbox it back to an int,
            /// and the restrictions on manipulating boxed values directly.
            /// </summary>
            Console.WriteLine("Boxed object: " + obj+"Datatype: "+obj.GetType().Name);
            //obj++; // Incrementing the boxed value, which is not allowed directly on an object type.
            int unboxedValue = (int)obj; // Unboxing: object to int
            Console.WriteLine("Unboxed value: " + unboxedValue+ "Datatype: " + unboxedValue.GetType().Name);
            unboxedValue++;// Incrementing the unboxed value

            Console.WriteLine("Incremented unboxed value: " + unboxedValue + "Datatype: " + unboxedValue.GetType().Name);   
        }
    }
}
