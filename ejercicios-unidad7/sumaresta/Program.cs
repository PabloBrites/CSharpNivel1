using System;

namespace sumaresta
{
    class Program
    {
        static void Main(string[] args)
        {
            //hacer una funcion que se llame "sumaresta" que reciba dos numeros y que devuelva la suma y la resta
            //del primer numero con el segundo.
            
            
            
            int a, b, suma;

            Console.WriteLine("Ingrese un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro");
            b = int.Parse(Console.ReadLine());

            suma = sumaresta(a, ref b);

            Console.WriteLine("El resultado de la suma del primer numero con el segundo es: " + suma);
            Console.WriteLine("El resultado de la resta del primer numero con el segundo es: " + b);

        }
        
        static int sumaresta(int n1, ref int n2){
            
            int suma  = n1 + n2;
            n2 = n2 - n1;      //<--  //aca vamos a pisar el valor de n2, primero se lee el valor de n2 despues el de
                                      //n1, se resta, y luego se pisa el valor de n2 (acordate que cuando pasamos un valor
            return suma;              //por referencia si modificamos ese valor en la funcion, va a impactar directamente
                                      //el cambio en el main)
        }
    }   
}
        