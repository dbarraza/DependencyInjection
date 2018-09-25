using Interfaces;
using System;
using System.Reflection;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var assemblyExterno = Assembly.LoadFile(@"C:\Users\Arkano\source\repos\DependencyInjection\Implementation\bin\Debug\Implementation.dll");
            var tipos = assemblyExterno.GetExportedTypes();
            IFuncionalidad objetoConcreto = (IFuncionalidad)Activator.CreateInstance(tipos[0]);
            Console.WriteLine(objetoConcreto.ObtenerText());
        }
    }
}
