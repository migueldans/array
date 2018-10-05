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

            ////Crear un array de 3 strings. Pedir al usuario 3 veces que escriba un string. 
            ////Guardar cada uno de esos strings en la posición 0 , 1 y 2. Mostrar en pantalla en el orden: primero posición 1, después posición 2 y por último posicion 0.

            //string sting1, sting2, sting3;

            //Console.WriteLine("Dime una cancion de sting");
            //sting1 = Console.ReadLine();

            //Console.WriteLine("Dime una cancion otra sting");
            //sting2 = Console.ReadLine();

            //Console.WriteLine("Dime una cancion otra mas sting");
            //sting3 = Console.ReadLine();

            //string[] arraySting = { sting1, sting2, sting3 };

            //Console.WriteLine(arraySting[1]);
            //Console.WriteLine(arraySting[2]);
            //Console.WriteLine(arraySting[0]);

            //Console.ReadLine();

            ////Crear un array de 10 ints. Usar un for para asignar los valores de 20 a 11 a las 10 posiciones (en orden descendente). Usar un for para mostrar los 10 valores en pantalla.
            ////solo se hace con un for

            //int contar= 20;
            //int[] numeros = new int[10];

            //for( int i=0; i<numeros.Length;i++)
            //{
            //    numeros[i] = contar;
            //    contar--;
            //    Console.WriteLine(numeros[i]);
            //}

            //Console.ReadLine();

            ////Crear un array de 3 ints. Usar un for para pedir al usuario que introduzca valores a cada una de las posiciones. Usar otro for para mostrarlos en pantalla.

            //int[] tres = new int[3];
            //for(int i=0;i<tres.Length;i++)
            //{

            //    Console.WriteLine("Introduzca un valor ");
            //    tres[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //for(int i= 0;i<tres.Length; i++)
            //{

            //    Console.Write(tres[i] + " ");

            //}

            //Console.ReadLine();

            //Crear un array de 3 ints. Usar un for para pedir al usuario que introduzca valores a cada una de las posiciones.
            //Mirar los valores del array una vez tenga los 3 valores y mostrar en pantalla el más pequeño.

            //int minimo = 0;
            //int[] three = new int[3];
            //for (int i = 0; i < three.Length; i++)
            //{
            //    Console.WriteLine("Introduzca un valor:");
            //    three[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < three.Length; i++)
            //{
            //    if (three[0] < three[1] && three[0] < three[2])
            //    {
            //        minimo = three[0];

            //    }
            //    if (three[1] < three[0] && three[1] < three[2])
            //    {
            //        minimo = three[1];
            //    }
            //    if (three[2] < three[0] && three[0] < three[1])
            //    {
            //        minimo = three[2];
            //    }
            //}

            //Console.ReadLine();

            ////+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++AQUI HAY QUE DEFINIR UN COMPARADOR PERO NO ESTA DEL TODO BIEN++++++++++++++++++++++++

            //int comparador = 100000;
            //for (int i = 0; i < three.Length; i++)
            //{
            //    Console.WriteLine("Introduzca un valor:");
            //    three[i] = Convert.ToInt32(Console.ReadLine());

            //    if (comparador > three[i])
            //    {
            //        comparador = three[i];
            //    }
            //}

            //Console.ReadLine();



            ////+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++EN ESTE SE CARGA EL PAQUETE LINQ+++++++++++++++++++++++++++++++++++++++++++++++++++

            //for (int i = 0; i < three.Length; i++)
            //{
            //        Console.WriteLine("Introduzca un valor:");
            //        three[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("El valor más  pequeño es " + three.Min());
            //Console.ReadLine();

            ////Poner los nombres de los meses en un array de 12. Cuando el usuario introduce un número del 1 al 12, mostrar el nombre de ese mes en pantalla.

            //int numero;
            //string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            //Console.WriteLine("Escribe un numero del 1 al 12");
            //numero = Convert.ToInt32(Console.ReadLine());

            //while (numero <= 0 || numero > 12)
            //{
            //    Console.WriteLine("Introduzca mes correcto");
            //    numero = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("El mes elegido es: " + meses[numero - 1]);
            //Console.ReadLine();

            ////Hacer la media de 10 valores utilizando un array.

            //int[] valors = new int[10];

            //for (int i = 0; i < valors.Length; i++)
            //{
            //    Console.WriteLine("Escribe un numero");
            //    valors[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("La media es " + (valors.Average()));
            //Console.ReadLine();

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++OTRO METODO+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //int[] arrayXmedia = { 6, 5, 3, 5, 5, 5, 5, 3, 3, 5 };
            //double media = 0;

            //for (int i = 0; i < arrayXmedia.Length; i++) 
            //{
            //    media = arrayXmedia[i] + media;
            //}
            //media = media / arrayXmedia.Length;
            //Console.Write(media);
            //Console.ReadLine();

            ////Crear un array de 11 ints. Pedir al usuario que introduzca valores entre 0 y 10. Cada vez que introduzca un dígito, añadir uno al valor en esa posición del array.
            ////Si por ejemplo introduce un 3, sumar uno a la posición 3. Mostrar en pantalla los valores. Si introduce un número mayor que 10, decir que ese número es incorrecto. 
            ////Si introduce un número negativo, mostrar en pantalla el número de cada posición y el valor que contiene.


            //int[] sumar = new int[11];
            //int numero = 0;
            //int[] once = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            //while (numero >= 0 && numero <= 10)
            //{
            //    Console.WriteLine("Escribe un numero del 1 al 10");
            //    numero = Convert.ToInt32(Console.ReadLine());

            //    while (numero > 10)
            //    {
            //        Console.WriteLine("Error, Escribe un numero del 1 al 10");
            //        numero = Convert.ToInt32(Console.ReadLine());
            //    }
            //    for (int i = 0; i < once.Length; i++)
            //    {
            //        if (numero == once[i])
            //        {
            //            sumar[i]++;
            //        }
            //    }

            //}

            //for (int i = 0; i < sumar.Length; i++)
            //{
            //    Console.WriteLine(once[i] + "\t" + sumar[i]);
            //}


            //Console.ReadLine();

            //Crear un array de 10 valores. Poner el valor 1 en cada una de la posición. Pedir al usuario que introduzca un número entre 0 y 9.
            //Cada vez que introduzca un valor entre 0 y 9, mostrar el valor de esa posición del array, y modificarlo multiplicando por 2.

            int[] valor = new int[10];
            int numero = 0;      
            
            for (int i=0; i<valor.Length; i++)
            {
                valor[i] = 1;
            }

            while (numero >= 0 && numero <= 9)
            {
                Console.WriteLine("Introduzca un número entre 0 y 9 ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero >= 0 && numero <=9)
                {
                    valor[numero] = valor[numero] * 2;
                    Console.WriteLine(valor[numero]);
                }
                
            }
            for(int i = 0;i < valor.Length;i++)
            {
                Console.WriteLine(valor[i]);
                
            }
            Console.ReadLine();
        }
    }
}
