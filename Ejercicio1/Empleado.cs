using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Empleado : Persona
    {
        public override void MuestraDatos()//irpf, tel
        {
            base.MuestraDatos();
            Console.WriteLine("{0}€", Salario);
        }

        public void MuestraDatos(int pedido)//Solo 1 parametro
        {
            switch (pedido)
            {
                case 1:
                    Console.WriteLine("Nombre:", base.Nombre);
                    break;
                case 2:
                    Console.WriteLine("Apellidos:", base.Apellidos);
                    break;
                case 3:
                    Console.WriteLine("Edad:", base.Edad);
                    break;
                case 4:
                    Console.WriteLine("DNI:", base.Dni);
                    break;
                case 5:
                    Console.WriteLine("Salario:", Salario);
                    break;
                case 6:
                    Console.WriteLine("Teléfono:", Telefono);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }

        public override double hacienda()
        {
            return Irpf * Salario / 100;
        }

        private double salario;
        public double Salario
        {
            get
            {
               
                return salario;
            }
            set//Cambiar irpf
            {

                salario = value;
                switch (value)  //En el set
                {
                    case double n when (n <= 600):
                        irpf = 7;
                        break;
                    case double n when (n >= 3000):
                        irpf = 20;
                        break;
                    default:
                        irpf = 15;
                        break;
                }
            }
        }

        private double irpf;
        private double Irpf
        {
            get
            {
                return irpf;
            }
        }

        private string telefono;
        public string Telefono
        {
            get
            {
                return "+34" + telefono;
            }
            set
            {
                telefono = value;
            }
        }

        public Empleado(string nombre, string apellidos, int edad, string dni, int salario, string telefono)
            : base(nombre, apellidos, edad, dni)
        {
            this.Salario = salario;
            this.Telefono = telefono;
        }

        public Empleado()
        : this("", "", 0, "39485142", 0, "")
        {
        }
    }
}
