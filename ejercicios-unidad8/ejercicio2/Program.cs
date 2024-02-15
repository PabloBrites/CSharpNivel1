using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            //Luego recorrer los elementos y determinar e informar cuál es el valor máximo 
            //y su posición dentro del vector.

            int[] Vnum = new int[10]; 
            
            int n, max = 0, posición = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero por favor...");
                n = int.Parse(Console.ReadLine());
                Vnum[x]=n;
            }

            for (int x = 0; x < 10; x++)
            {
               if(Vnum[x] > max)
               {
                    max = Vnum[x];
                    posición = x + 1;
               } 
            }

            Console.WriteLine("El valor maximo es: " + max + " y se encuentra en la posicion + " + posición + " del vector"); 
        }
    }
}

//Aclaraciones:

//Excelente, has ajustado tu lógica correctamente al sumar 1 a posición cuando encuentras un nuevo valor máximo. 
//Esto es necesario porque en los arrays, los índices comienzan desde 0. Al sumar 1, obtienes la posición del valor 
//máximo de una manera más intuitiva desde la perspectiva del usuario

//En muchos lenguajes de programación, incluido C#, los índices de los arrays comienzan desde 0. 
//Esto significa que el primer elemento de un array tiene un índice de 0, el segundo tiene un índice de 1, 
//y así sucesivamente. Por ejemplo:

//En el código que proporcionaste, estás buscando el valor máximo en el array y guardando su posición en la variable
//posición. Al comparar los valores en el array, si encuentras un nuevo valor máximo en la posición x, guardas esa 
//posición en posición.

//Dado que estás presentando los resultados al usuario, y desde la perspectiva del usuario las posiciones podrían 
//ser más intuitivas si comienzan desde 1 en lugar de 0, decides sumar 1 a la variable posición. 
//Esta suma no afecta el funcionamiento interno del array, pero hace que la salida sea más natural para el usuario.

//Por ejemplo, si el valor máximo está en la posición 4 del array (que corresponde al índice 3), sumar 1 a posición
//hace que la variable tenga el valor 4. Así, cuando imprimes la posición del valor máximo, mostrarías 4 en lugar 
//de 3, que es más comprensible desde la perspectiva del usuario.



