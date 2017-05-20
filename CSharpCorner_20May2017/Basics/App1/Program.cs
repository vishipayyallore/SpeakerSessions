using static System.Console;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var assemblyNames = new string[] { "ArrayLib", "StringLib" };
            //const string METHODNAME = "Run";

            var metadata = GetMetadata("appsettings.json");

            foreach (var current in metadata)
            {
                RunPrograms(current.AssemblyName, current.MethodName);
            }
            

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

        private static void RunPrograms(string assemblyName, string methodName)
        {
            var programsAssembly = Assembly.Load(new AssemblyName(assemblyName));
            foreach (var currentClass in programsAssembly.GetTypes())
            {
                var currentMethod = currentClass.GetMethod(methodName);
                WriteLine($"{currentClass.Name} ....");
                currentMethod.Invoke(System.Activator.CreateInstance(currentClass), null);
            }
        }

        static List<Metadata> GetMetadata(string metadataFilePath)
        {
            var metadataFileStream = File.Open(metadataFilePath, FileMode.Open);
            var serializer = new DataContractJsonSerializer(typeof(List<Metadata>));
            return (List<Metadata>)serializer.ReadObject(metadataFileStream);
        }
    }
}
