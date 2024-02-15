using System;
using System.Globalization;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //ejemplo de uso de vectores.......

            int n, acu, prom;
            int[] numeros = new int[10]; 

            for (int x = 0; x < 10; x++)    
            {
                Console.WriteLine("Ingrese la Nota: ");         //*como escribir un vector de numeros enteros
                n = int.Parse(Console.ReadLine());
                numeros[x] = n;
                
            }

            acu = 0; 
            
            for (int x = 0; x < 10; x++)
            {
                acu += numeros[x];                              //*como leer un vector de numeros enteros
                Console.WriteLine(numeros[x]);           //<--  //mostrar todos los elemrntos, que en este caso
                                                                //es solo para mostrar no hace falta 
            }                                                   //agregarlo

            prom = acu / 10; // la suma de los elementos dividido la cantidad de los mismos

            Console.WriteLine("El promedio de numeros es: " + prom); 

            
            //Console.Write("Los numeros que se ingresaron fueron: "); 

            //for (int x = 0; x < 10; x++)
            //{
                
                //Console.Write(numeros[x] + " ");         /<-- // *mostrar los numeros de forma ordenada que se 
                                                                //  ingresaron, las comillas dobles se utilizan para
                                                                //  agregar un espacio en blanco entre cada numero
                                                                
                                                                // * el Write es útil cuando deseas imprimir en la 
                                                                //   misma línea
            //}                                         

        }  
    }       
}


//acu += numeros[x]; cuando llega a este punto el vector ya esta cargado? 
//cuando llega al segundo for, el vector adentro ya posee los 10 numeros?

// Sí, exactamente. En tu código, el primer bucle for se encarga de solicitar al usuario que ingrese las 10 notas 
//y almacenarlas en el arreglo numeros. Luego, después de la ejecución de ese bucle, el arreglo numeros ya está 
//completamente cargado con las 10 notas ingresadas.

//Cuando comienza el segundo bucle for:

//El arreglo numeros ya tiene los valores ingresados, y el bucle for itera sobre cada elemento del arreglo para 
//acumular la suma en la variable acu. Por lo tanto, en este punto, el vector ya posee los 10 números ingresados 
//por el usuario, y el segundo bucle está sumando esos números en la variable acu

//ahhhhhhhhh oki oki osea que en el segundo for ya llegan los numeros cargados en el vector, 
//y en acu se van a acumular los numeros de ese vector, si x vale 0 se guarda en acu lo que esta guardado 
//en el indice cero del vector y asi

//Exactamente, has entendido correctamente. En el segundo bucle for, la variable x actúa como el índice del arreglo
// numeros. En cada iteración del bucle, se accede al elemento en la posición x del arreglo (numeros[x]) y se suma
//a la variable acu. En resumen, el bucle recorre todos los elementos del vector y acumula la suma total de esos 
//elementos en la variable acu.