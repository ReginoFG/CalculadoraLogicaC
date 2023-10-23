using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogicaC.Servicios
{
    /// <summary>
    /// Definir los métodos de solicitud de información
    /// </summary>
    /// <author>231023 - rfg</author>
    internal interface PeticionesInterfaz
    {
        /// <summary>
        /// Solicitar la expresión y recoger el valor.
        /// </summary>
        /// <returns>string - Expresión dada por el usuario</returns>
        public string solicitarExpresion();
        /// <summary>
        /// Mostrar el menú de selección y recoger la opción.
        /// </summary>
        /// <returns>int - opción seleccionada por el usuario</returns>
        public int mostrarMenuYSeleccionarOpcion();

    }
}
