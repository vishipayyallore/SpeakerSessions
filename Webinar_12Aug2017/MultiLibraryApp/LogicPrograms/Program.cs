using static System.Console;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using DataCore;

namespace LogicPrograms
{
    /// <summary>
    /// Project created in Windows 10. 
    /// Updated in Ubuntu 14.04.
    /// Updated in Mac OS X too.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var metadata = GetMetadata("appsettings.json");

            foreach (var current in metadata)
            {
                ExecuteMethods(current);
            }

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

        #region Private Methods.
        private static void ExecuteMethods(Metadata currentAssembly)
        {
            var programsAssembly = Assembly.Load(new AssemblyName(currentAssembly.AssemblyName));
            foreach (var currentClass in programsAssembly.GetTypes())
            {
                var currentMethod = currentClass.GetMethod(currentAssembly.MethodName);
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
        #endregion
    }
}