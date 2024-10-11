using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    abstract class Persona
    {
        public virtual void MuestraDatos()
        {
            Console.WriteLine(Nombre);
            Console.WriteLine(Apellidos);
            Console.WriteLine(Edad.ToString());
            Console.WriteLine(Dni);
        }

        public virtual void IntroduccirDatos()
        {
            Console.WriteLine("¿Qué nombre tienes?");
            Nombre = Console.ReadLine();
            Console.WriteLine("¿Qué apellidos tienes?");
            Apellidos = Console.ReadLine();
            Console.WriteLine("¿Cuántos años tienes?");
            string edadstring = Console.ReadLine();
            Edad = Convert.ToInt32(edadstring);
            Console.WriteLine("¿Cuál es tu DNI? (Sin letra)");
            Dni = Console.ReadLine();
        }
        private string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        private string apellidos;
        public string Apellidos
        {
            get
            {
                return apellidos;
            }
            set
            {
                apellidos = value;
            }
        }

        private int edad;
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                edad = value;
            }
        }
        private string dni;
        public string Dni //Dividir el numero entre 23 y el resto determina la letra
        {
            get
            {
                double valueentero = Convert.ToInt32(dni);//Esto en el get
                double resto = valueentero % 23;
                string letra="";
                switch (resto)
                {
                    case 0:
                        letra = "T";
                        break;
                    case 1:
                        letra = "R";
                        break;
                    case 2:
                        letra = "W";
                        break;
                    case 3:
                        letra = "A";
                        break;
                    case 4:
                        letra = "G";
                        break;
                    case 5:
                        letra = "M";
                        break;
                    case 6:
                        letra = "Y";
                        break;
                    case 7:
                        letra = "F";
                        break;
                    case 8:
                        letra = "P";
                        break;
                    case 9:
                        letra = "D";
                        break;
                    case 10:
                        letra = "X";
                        break;
                    case 11:
                        letra = "B";
                        break;
                    case 12:
                        letra = "N";
                        break;
                    case 13:
                        letra = "J";
                        break;
                    case 14:
                        letra = "Z";
                        break;
                    case 15:
                        letra = "S";
                        break;
                    case 16:
                        letra = "Q";
                        break;
                    case 17:
                        letra = "V";
                        break;
                    case 18:
                        letra = "H";
                        break;
                    case 19:
                        letra = "L";
                        break;
                    case 20:
                        letra = "C";
                        break;
                    case 21:
                        letra = "K";
                        break;
                    case 22:
                        letra = "E";
                        break;
                }
                return dni+letra;//+ letra
            }
            set
            {
                dni = value;
            }
        }

        public Persona(string nombre, string apellidos, int edad, string dni)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
            this.Dni = dni;
        }

        public Persona()
            : this("", "", 0, "39485142")
        {

        }

        public abstract double hacienda();

    }
}
