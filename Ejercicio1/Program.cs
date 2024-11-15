using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Prueba : Persona
    {
        public override double hacienda()
        {
            return 0;
            // throw new NotImplementedException();
        }
    }
    internal class Program
    {
        public static void Main()
        {
            /*
            Prueba p = new Prueba();
            p.Nombre = "Carlos";
            p.Apellidos = "Paz";
            p.Edad = 19;
            p.Dni = "39485142";
            Empleado esclavo = new Empleado();
            esclavo.Nombre = "Isma";
            esclavo.Apellidos = "Martinez";
            esclavo.Edad = 19;
            esclavo.Dni = "85792537";
            esclavo.Salario = 10;
            esclavo.Telefono = "30457457";
            */
            Directivo carlos = new Directivo();
            carlos.IntroduccirDatos();
        }
    }
}
