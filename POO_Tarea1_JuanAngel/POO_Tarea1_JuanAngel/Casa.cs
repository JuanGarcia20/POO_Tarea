using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea1_JuanAngel
{
    internal class Casa
    {
        public string nombreDuenoCasa, apellidoDuenoCasa, maerialCasa;
        double precioVentaCasa, engancheCasa;

       public ConsoleColor colorCasa;

        //propiedades
        public double EngancheCasa
        {
            get { return engancheCasa; } //obtener
            set { engancheCasa = value; }//enviar
        }

        public ConsoleColor ColorCasa
        {
            get { return colorCasa; } //obtener
            set { colorCasa = value; }//enviar

        }

        public double PrecioVentaCasa
        {
            get { return precioVentaCasa; } //obtener
            set { precioVentaCasa = value; }//enviar

        }

    }
}
