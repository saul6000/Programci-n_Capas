using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaOperacion
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Funciones.Operaciones op = new Funciones.Operaciones();
            double[] y = new double[] { 10, 12, 12, 13, 15, 17 };
           // y[0]= 12; y[1] = 22; y[2] = 100; y[3] = 20; y[4] = 33;
            double x = op.suma(y);
            Console.WriteLine(op.saludo("Saúl"));
            Console.WriteLine("La suma del array es {0}", x);
            Console.ReadKey();

    }
        }
    }

