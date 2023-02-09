using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_metodo_y_variable
{
     class operaciones
    {
        //variables 
        private int numero1;
        private int numero2;
        private int suma;
        private int resta;
        private int multiplicacion;
        private float division;

        //Metodo para cargar datos
        public void Inicializar()
        {
            string var;
            Console.WriteLine("Ingrese el primer numero");
            var= Console.ReadLine();
            numero1= int.Parse(var);
            Console.WriteLine("Ingrese el segundo numero");
            var= Console.ReadLine();
            numero2= int.Parse(var);
        }
        public void operacion()
        {
            suma = numero1 + numero2;
            resta = numero1 - numero2;
            multiplicacion= numero1 * numero2;
            division = numero1 / numero2;

        }

        public void Imprimirresultado()
        {
            Console.Write("La suma es:");
            Console.WriteLine(suma);
            Console.Write("La resta es:");
            Console.WriteLine(resta);
            Console.Write("La multiplicacion es:");
            Console.WriteLine(multiplicacion);
            Console.Write("La division es:");
            Console.WriteLine(division);
        }

        static void Main(string[] args)
        {
            operaciones op=new operaciones();
            op.Inicializar();
            op.operacion();
            op.Imprimirresultado();
            Console.ReadKey();

        }
    }
}
