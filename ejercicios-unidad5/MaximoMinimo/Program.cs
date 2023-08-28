using System;

namespace MaximoMinimo
{
    class Program
    {
        static void Main(string[] args)
        {
            //hacer un programa para ingresar una lista de diez numeros, luego informar el maximo y el minimo.

            int n, min = 0, max = 0;
            
            for (int x = 0; x < 10 ; x++)
            {
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                if(x == 0)
                    max = n;
                else{
                    if(n > max)
                        max = n;
                }
                if(x == 0)
                    min = n;
                else{
                    if(n < min)
                        min = n;
                }                
            }   
            Console.WriteLine("El maximo es: " + max);
            Console.WriteLine("El minimo es: " + min);
        }
    }
}
                //ejercicio guia de maxi utn
                //Hacer un programa para ingresar una lista 10 números e informar el máximo de los
                //negativos y el mínimo de los positivos.
                //Ejemplo: 5, 8, 12, 2, -10, 15, -20, 8, -3, 24. Máximo Negativo -3. Mínimo Positivo 2.
                
                //for (int x = 0; x < 10; x++){

                //Console.WriteLine("Ingrese un numero por favor:");
                //n = int.Parse(Console.ReadLine());

                // //if(n < 0){
                    //conNeg++;
                //if(conNeg == 1)
                    //max = n;
                //else if(n > max)
                    //max = n;
                
                //}else{                 
                    //conPos++;
                //if(conPos == 1)
                    //min = n;
                //else if(n < min)
                    //min = n;
                //}
            //}   
            //Console.WriteLine("el maximo negativo es " + max); 
            //Console.WriteLine("el minimo positivo es " + min);//