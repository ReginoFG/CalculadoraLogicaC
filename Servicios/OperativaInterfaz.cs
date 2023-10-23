using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogicaC.Servicios
{
    /// <summary>
    /// Definir los métodos de la operativa de la aplicación
    /// </summary>
    /// <author>321023 - rfg</author>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Comparar las dos expresiones basándose en == e indicar por consola el resultado
        /// </summary>
        /// <param name="expresion1"></param>
        /// <param name="expresion2"></param>
        public void compararIgualdadExpresiones(string expresion1, string expresion2);

        /// <summary>
        /// Comparar las dos expresiones basándose en != e indicar por consola el resultado
        /// </summary>
        /// <param name="expresion1"></param>
        /// <param name="expresion2"></param>
        public void compararDesigualdadExpresiones(string expresion1, string expresion2);
    }
}
