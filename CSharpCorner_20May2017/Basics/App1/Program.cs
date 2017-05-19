using static System.Console;
using System.Reflection;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            var assemblyNames = new string[] { "ArrayLib", "StringLib" };
            const string METHODNAME = "Run";

            foreach (var assemblyName in assemblyNames)
            {
                RunPrograms(assemblyName, METHODNAME);
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
    }
}
