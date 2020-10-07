using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_01_CHINO_CONDE
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            string nombre;
            string apellido = "Chino Conde";
            int edad = 25;
            double talla = 1.70;
            bool sexo = true;

            //Ingresar por teclado
            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();

            //Imprimir en pantalla
            Console.WriteLine("Nombre:" + nombre);
            Console.WriteLine("Apellido:" + apellido);
            Console.WriteLine("Edad:" + edad);
            Console.WriteLine("Estatura:" + talla);
            //Console.WriteLine("Sexo:"
                if (sexo == true) { Console.WriteLine("Sexo: " + "M"); }
                else { Console.WriteLine("Sexo: " + "F"); }

            Console.ReadKey();



        }
    }
}
