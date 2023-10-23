using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogicaC.Servicios
{
    /// <summary>
    /// Implementación de la interfaz de operativa
    /// </summary>
    /// <author>231023 - rfg</author>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void compararIgualdadExpresiones(string expresion1, string expresion2)
        {
            if (expresion1==expresion2)
            {
                Console.WriteLine("[IGUALDAD] - Las expresiones son iguales");
            }
            else
            {
                Console.WriteLine("[IGUALDAD] - Las expresiones no son iguales");
            }
        }

        public void compararDesigualdadExpresiones(string expresion1, string expresion2)
        {
            if (expresion1 != expresion2)
            {
                Console.WriteLine("[DESIGUALDAD] - Las expresiones no son iguales");
            }
            else
            {
                Console.WriteLine("[DESIGUALDAD] - Las expresiones son iguales");
            }
        }
    }
}
