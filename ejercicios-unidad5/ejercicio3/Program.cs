using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
           //Hacer un programa que solicite 20 edades y luego calcule el promedio
           //de edad de aquellas personas mayores a 18 años.

            int n, contador = 0, acumulador = 0, promedio = 0;

            
            for (int i = 0; i < 5; i++){
                Console.WriteLine("Ingrese su edad: ");
                n = int.Parse(Console.ReadLine());
                if(n > 18){
                   acumulador+= n;
                   contador++;
                }  
                promedio = acumulador / contador;  
            }   Console.WriteLine("El promedio de edad de personas mayores a 18 son: " + promedio);
        }   
    }
}
