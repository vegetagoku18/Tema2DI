using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Directivo : Persona
    {
        public Directivo() { }

        public override double hacienda()
        {
            return 2;
        }

        private string departamentos;
        public string Departamentos
        {
            get
            {
                return departamentos;
            }
            set
            {
                departamentos = value;
            }
        }

        private int trabajadores;
        public int Trabajadores
        {
            get
            {
                return trabajadores;
            }
            set
            {
                trabajadores = value;
            }
        }

        private double beneficios;
        public double Beneficios
        {
            get
            {
                switch (Trabajadores)
                {
                    case int n when (n < 11):
                        beneficios = 2;
                        break;
                    case int n when (n > 50):
                        beneficios = 4;
                        break;
                    default:
                        beneficios = 3.5;
                        break;
                }
                return beneficios;
            }
            set
            {
                beneficios = value;
            }
        }
        public static Directivo operator --(Directivo p1)
        {
            if (p1.beneficios >= 1)
            {
                p1.beneficios--;
            }
            else
            {
                p1.beneficios = 0;
                Console.WriteLine("No puede bajar más");
            }
            return p1;
        }

        public override void MuestraDatos()
        {
            base.MuestraDatos();
            Console.WriteLine("{0}", Departamentos);
            Console.WriteLine("{0}%", Beneficios);
            Console.WriteLine("{0}", Trabajadores);
        }

        public override void IntroduccirDatos()
        {
            base.IntroduccirDatos();
            Console.WriteLine();
        }
    }
}
