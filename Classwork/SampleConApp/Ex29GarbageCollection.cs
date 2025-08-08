using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Garbage collection is internal memory managment system of .NET Framework. It is used to manage memory of application and ensures that unused objects/memory is removed behind the scenes as and when its required 
//its is recommended not to be touched unless vr working with unmanaged code.code that is executed in .net is managed by CLR (Common Language Runtime) and CLR is responsible for memory management and garbage collection.hence , its called managed code
//Destructors r used to clean up resources managed by clr.. it id done internally by GC(Garbage collector) thru .net clr
//they dont have any parameters ,nor return type ,, or can be inherited or invoked explicitly,,no access modifiers can be used 
//to explicitly call an destructor of unmanaged code , .net recommends ti impement IDisposable interface and use the Dispose method to clean up resources.. dispose method shd be called when object is no longer in use 
//using block helps in calling dispose method implicitly after object goes out of scope ,
namespace SampleConsoleApp1
{
    class SimpleObject: IDisposable
    {
        private int _id;
        public SimpleObject(int id)
        {
            _id = id;
            Console.WriteLine($"Object with ID {_id} created.");
        }
        ~SimpleObject()
        {
            Console.WriteLine($"{_id} object is destroyed");
        }
        public void Dispose()
        {
            Console.WriteLine($"{_id} object is destroyed");
            GC.SuppressFinalize(this); // Suppress finalization to prevent the destructor from being called
        }
    }
    internal class Ex29GarbageCollection
    {
        static void Main(string[] args)
        {
            CreateAndDestroy();
        }

        static void CreateAndDestroy()
        {
            for(int i = 0; i < 5; i++)
            {
                using (SimpleObject obj = new SimpleObject(i))
                {
                    // Simulate some work with the object
                    Console.WriteLine($"Working with object {i}");
                } // Dispose is called here, and destructor will not be called
            }
        }
    }
}
