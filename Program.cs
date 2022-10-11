using System;

namespace actividad5TP7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desarrolle un programa que permita calcular el FACTORIAL para un número entero
            ingresado por el usuario. EL concepto de factorial para un numero N, es que se obtiene de
            realizar la multiplicación de todos los números entre 1 y N.*/
            
            int n = 0;
            int numero = 0;
            int factorial = 1;
            string valor = "";

            Console.WriteLine("Dame el número al que se le saca el factorial:");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);

            for (n = numero; n >= 1; n--)
            {
                factorial *= n;
            }

            Console.Clear();

            Console.WriteLine("El factorial de {0} es {1}", numero, factorial);

        }
    }
}
