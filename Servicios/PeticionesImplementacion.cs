using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogicaC.Servicios
{
    internal class PeticionesImplementacion : PeticionesInterfaz
    {
        public int mostrarMenuYSeleccionarOpcion()
        {
            int opcion;

            Console.WriteLine("0. Cerrar");
            Console.WriteLine("1. Comparación con igualdad");
            Console.WriteLine("2. Compraración con desigualdad");
            Console.WriteLine("Solicite una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }

        /// <summary>
        /// Implementación de la interfaz de peticiones
        /// </summary>
        /// <author>231023 - rfg</author>
        public string solicitarExpresion()
        {
            string expresion;

            Console.WriteLine("Escriba una expresión de texto: ");
            expresion = Console.ReadLine();

            return expresion;
        }
    }
}
