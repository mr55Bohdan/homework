using System;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace System.Xml.Serialization
//namespace Fibonacci_serializator
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 0, b = 1, c = 0;
            //
            Runtime.Serialization.IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("test_bin.bin",
            FileMode.Create, FileAccess.Write, FileShare.None);

            

            //
            XmlSerializer xmlser = new XmlSerializer(typeof(long));
            Stream serialStream = new FileStream("test_xm.xml", FileMode.Create);

            //
            Stream file = new FileStream("test_js.json", FileMode.Create);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(long));
            



            for (int i = 0; i < 100; i++)
            {
                c = a + b;
                a = b;
                b = c;
                xmlser.Serialize(serialStream, (c));
                ser.WriteObject(file, c);
                formatter.Serialize(stream, c);
                
            }
            stream.Close();

            //Console.WriteLine("Hello World!");
        }
    }
}
