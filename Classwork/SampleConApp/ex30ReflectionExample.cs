using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp1
{
    //Reflection is feature of .net framework that allows us to inspect metadata of types at runtime. it is used to dynamically create instances of types, invoke methods, access properties and fields, and more.
    internal class ex30ReflectionExample
    {
        static void Main(string[] args)
        {
            var dllLoc= @"C:\Users\6152774\source\repos\CSBasics\ConsoleSol\SampleCoreLib\bin\Debug\SampleCoreLib.dll";
            Assembly assembly = Assembly.LoadFile(dllLoc);
            if (assembly == null)
            {
                Console.WriteLine("Assembly not found.");
                return;
            }
            //Get all the Types in the assembly
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
                Console.WriteLine(type.FullName);
            Console.WriteLine("Enter the Fullname of the Type from the List above");
            string typeName = Console.ReadLine();
            Type selectedType = assembly.GetType(typeName, false, true);
            if (selectedType == null)
            {
                Console.WriteLine("Selected Type is wrong");
                return;
            }
            MemberInfo[] members = selectedType.GetMembers(BindingFlags.Public | BindingFlags.Instance);
            foreach (MemberInfo member in members)
            {
                Console.WriteLine($"Member: {member.Name}, Type: {member.MemberType}");
            }
            //Get the member name to invoke
            Console.WriteLine("Enter the member name to invoke");
            string memberName = Console.ReadLine();
            MethodInfo method = selectedType.GetMethod(memberName);
            if (method == null)
            {
                Console.WriteLine("Method not found.");
                return;
            }
            //Get the parameters of the method.
            ParameterInfo[] parameters = method.GetParameters(); 
            if (parameters.Length == 0)
            {
                //If the method has no parameters, invoke it directly.
                object result = method.Invoke(Activator.CreateInstance(selectedType), null);
                Console.WriteLine($"Result: {result}");
                return;
            }
            else //this is the expected execution path for methods with parameters
            {
                List<object> parameterValues = new List<object>();
                foreach (ParameterInfo parameter in parameters)
                {
                    Console.WriteLine($"Enter the Value for the Parameter: {parameter.Name}, whose Data type is {parameter.ParameterType}");
                    string input = Console.ReadLine();
                    //Convert the input to the parameter type and add to the parameterValues list. 
                    object value = Convert.ChangeType(input, parameter.ParameterType);
                    parameterValues.Add(value);
                }
                Console.WriteLine("All parameters are set, now time to invoke");
                //Pass the parameters to the method and invoke it.
                //Create the instance of the object
                object instance = Activator.CreateInstance(selectedType);

                if (instance == null)
                {
                    Console.WriteLine("object could not be created");
                    return;
                }
                object result = method.Invoke(instance, parameterValues.ToArray());
                Console.WriteLine("The result: " + result);
            }
        }
    }
}
