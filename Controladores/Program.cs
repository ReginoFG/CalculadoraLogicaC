using CalculadoraLogicaC.Servicios;

namespace CalculadoraLogicaC
{
    class Program
    {
        static public void Main(string[] args)
        {
            string exp1, exp2;
            PeticionesInterfaz pi = new PeticionesImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();

            bool esCerrar = false;
            int opcionSeleccionada;

            while (!esCerrar)
            {
                opcionSeleccionada = pi.mostrarMenuYSeleccionarOpcion();
                switch (opcionSeleccionada)
                {
                    case 0:
                        esCerrar = true;
                        break;
                    case 1:
                        exp1 = pi.solicitarExpresion();
                        exp2 = pi.solicitarExpresion();
                        oi.compararIgualdadExpresiones(exp1,exp2);
                        break;
                    case 2:
                        exp1 = pi.solicitarExpresion();
                        exp2 = pi.solicitarExpresion();
                        oi.compararDesigualdadExpresiones(exp1,exp2);
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;

                }
            }


        }
    }
}
