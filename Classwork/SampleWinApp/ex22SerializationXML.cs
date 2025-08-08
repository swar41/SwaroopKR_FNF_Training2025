using System;
using System.Text.Json;
using System.Xml.Serialization;

//Serialization is a feature of allowing an object to be stored into a file or a database. Here we store the object in a file. Not the data.
//The object typically has a class definition, metadata and other information that allows it to be reconstructed later.
//This is useful for persisting the state of an object or transferring it over a network. Mostly used for IPC.
//.NET supports serialization thru' BinaryFormatter(Binary), XmlSerializer(Xml), DataContractSerializer(WCF), and JSON serialization(JSON).
//Any Serialization has 3 steps: What to Serialize(objects of a class that has attribute called Serializable), How to Serialize(Binary, Xml, Soap, Json, WCF), and Where to Serialize(Files, Memory Streams, databases).
//For Xml Serialization, the class must have a parameterless constructor and public properties. The class must be public.
namespace SampleConApp
{
    public class Data
    {
        public DateTime CurrentDate { get; set; } = DateTime.Now;
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class Ex22SerializationExample
    {
        static void Main(string[] args)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Data));

            var data = new Data { Id = 1, CurrentDate = DateTime.Now.AddDays(-100), Name = "Swar" };
            xmlSerializer.Serialize(new System.IO.StreamWriter("data.xml"), data);
            Console.WriteLine("Data Serializwed");

            var sdata = (Data)xmlSerializer.Deserialize(new System.IO.StreamReader("data.xml"));
            Console.WriteLine($"The Name: {sdata.Name}, Date: {sdata.CurrentDate}");



        }
    }
}
