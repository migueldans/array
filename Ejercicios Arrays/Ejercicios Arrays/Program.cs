using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            ////darle la vuelta a un nombre, en este caso Jon

            //String nombre = "Jon";

            ////char[]arrayNombre= new char[3]
            ////arrayNombre=nombre.ToCharArray();

            //char[] arrayNombre = nombre.ToCharArray();

            //Array.Reverse(arrayNombre);

            //Console.Write(arrayNombre);

            //Console.ReadLine();

            ////Crear un array de 10 ints. Asignar un valor a cada uno de las 10 posiciones. Mostrar los 10 valores en pantalla.

            //int [] numeros = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 1 };
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.Write(numeros[i]);
            //}
            //Console.ReadLine();

            //Crear un array de 3 strings. Pedir al usuario 3 veces que escriba un string. 
            //Guardar cada uno de esos strings en la posición 0 , 1 y 2. Mostrar en pantalla en el orden: primero posición 1, después posición 2 y por último posicion 0.

            string sting1, sting2, sting3;
            
            Console.WriteLine("Dime una cancion de sting");
            sting1 = Console.ReadLine();

            Console.WriteLine("Dime una cancion otra sting");
            sting2 = Console.ReadLine();

            Console.WriteLine("Dime una cancion otra mas sting");
            sting3 = Console.ReadLine();

            string[] arraySting = { sting1, sting2, sting3 };

            Console.WriteLine(arraySting[1]);
            Console.WriteLine(arraySting[2]);
            Console.WriteLine(arraySting[0]);

            Console.ReadLine();

            //Crear un array de 10 ints. Usar un for para asignar los valores de 20 a 11 a las 10 posiciones (en orden descendente). Usar un for para mostrar los 10 valores en pantalla.
            //solo se hace con un for

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < numeros.Length; i++)
            {

            }

        }
    }
}
