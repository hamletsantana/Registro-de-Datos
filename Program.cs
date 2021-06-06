using System;
using System.IO;

namespace Registro_de_Datos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su cédula");
			int cedula = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Escriba su nombre");
			string nombre = Console.ReadLine();
			
			Console.WriteLine("Escriba su apellido");
			string apellido = Console.ReadLine();
			
			Console.WriteLine("Escriba su edad");
			int edad = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Desea grabar");
			string grabar = Console.ReadLine();
			
			
			string path = @"C:\Users\DELL\Documents\INTEC\Programación II\Registro de Datos\PATH.txt";
			
			using(StreamWriter reg = File.AppendText(path))
			{
				if (grabar == "si")
				{
					reg.WriteLine(cedula + ", " + nombre + ", " + apellido + ", " + edad );
					reg.Close();
				}
				else if (grabar == "no")
				{
					Environment.Exit(0);
				}
			}
        }
    }
}
