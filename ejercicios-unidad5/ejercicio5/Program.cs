using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares 
            //y el mínimo de los números impares.

            //si yo digo que tengo la variable n con un valor y uso el operador mod y lo divido por dos, y tengo 
            //como resto cero, el resultado es un numero par.
            
            int n, max = 0, min = 0;
            int conPar = 0, conImpar = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                if(n % 2 == 0){
                    conPar++;
                if(conPar == 1)
                    max = n;
                else if(n > max)
                    max = n;

            }else{
                conImpar++;
                if(conImpar == 1) 
                    min = n;
                else if(n < min)
                    min = n;
                }
            }          
                Console.WriteLine("El maximo par es: " + max);   
                Console.WriteLine("El minimo impar es: " + min);       
        }   
    }      
}
   