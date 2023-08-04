using System;

namespace ejercicio5BANDERA
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, max = 0, min = 0;
            bool banPar = false, banImpar = false;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                if(n % 2 == 0){
                if(banPar == false)                     
                    max = n; 
                    banPar = true;
                }                     
                else if(n > max)                        
                    max = n;                       

                else
                if(banImpar == false){                       
                    min = n;
                    banImpar = true;
                }
                else if(n < min)
                    min = n;
            }
                    
            Console.WriteLine("El maximo par es: " + max);   
            Console.WriteLine("El minimo impar es: " + min);  
        }
    }       
}

//la bandera es un concepto de variable usada especialmente para
//marcarme el camino,si la bandera esta en falso en este caso quiere
//quiere decir que no tengo un numero par maximo cargado y si la bandera  
//esta arriba quiere decir que ya tengo un numero maximo cargado.

//if(banPar == false) en este caso si la bandera de par esta en falso quiere decir que
//(no tengo PAR MAXIMO TODAVIA y que lo voy a inicializar max = n)
//if(n % 2 == 0){ aca si es par, pregunto, if(banPar == false) ¿tengo un par maximo guardado?

//Aca condicionalmente hay que analizarlo, if(banPar == false) aca tecnicamente estoy preguntando
//¿me falta un par falso? !si¡ entonces lo guardo aca: max = n; y despues voy a "cambiar" a la bandera de par
//le voy a asignar un true, banPar = true; ya que esto quiere decir que yo ahora ya tengo un numero maximo inicializado

//COMO PARA CERRAR
//ARRANCO: bool banPar = false declarando la variable y diciendo que no tengo un numero maximo par inicializado.

//if(n % 2 == 0) cuando encuentro un par, if(banPar == false) aca pregunto si tengo un par maximo ya guardado y digo 
//que efectivamente todavia no tengo.

//max = n; entonces aca lo guardo, lo asigno.

//banPar = true; y aca cambio la variable para confirmar que ya tengo, entonces la proxima vez cuando el ciclo vuelva
// a iterar y se ingrese un nuevo numero par va a preguntar, ¿ya tenes un numero par guardado? 
// y va a confirmar que ya tenes uno.

//entonces va a saltar al otro if, else if(n > max)                       
//                                  //max = n;
// y va a preguntar si el nuevo valor es mayor al maximo, si es mayor, el valor que posee n se le asigna a max. 


