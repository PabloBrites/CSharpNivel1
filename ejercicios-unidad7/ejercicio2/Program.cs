using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
            //Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            
            int n, con = 0, numero;

            for(int i = 0; i < 5; i++){
                Console.WriteLine("Ingrese un Numero: ");   
                n = int.Parse(Console.ReadLine());

                numero = par(n);
                if(numero == 1)
                    con++;
                
                
            }
            Console.WriteLine("la cantidad de numeros pares son: " + con);
        }
        

        static int par(int n1){
            if(n1 % 2 == 0)
                return 1;
            else
                return 0;
        }  
    }
}
