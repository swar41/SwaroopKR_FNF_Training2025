using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SampleWinApp
{
    internal class Ex22SerializationBin
    {
        [Serializable]//Anotations or additional logic that shall be added by the compiler to indicate that this class can be serialized.
        class Data
        {
            public DateTime CurrentDate { get; set; } = DateTime.Now;
            public int Id { get; set; }
            public string Name { get; set; }
        }
        internal class Program
        {
            private static void binarySerializationDemo()
            {
                saveData();//serialize
                loadData();//deserialize
            }

            //Deserialization is the process of reconstructing an object from a serialized format.
            private static void loadData()
            {
                var formatter = new BinaryFormatter();
                FileStream fs = new FileStream("data.bin", FileMode.Open, FileAccess.Read);
                object boxedData = formatter.Deserialize(fs);
                fs.Close();
                var unboxedData = boxedData as Data;
                Console.WriteLine($"The Name: {unboxedData.Name}, Date: {unboxedData.CurrentDate}");
            }

            private static void saveData()
            {
                //What: object of class Data
                var data = new Data { Id = 1, CurrentDate = DateTime.Now.AddDays(-100), Name = "Swar" };
                //Where
                var location = new FileStream("data.bin", FileMode.OpenOrCreate, FileAccess.Write);
                //How
                var formatter = new BinaryFormatter();
                formatter.Serialize(location, data);
                location.Close();
            }

            static void Main(string[] args)
            {
                binarySerializationDemo();
            }
        }
    }
}

