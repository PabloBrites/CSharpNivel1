﻿using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
         //Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. 
         //Para ello existe la siguiente escala de precios:

         //               i5 (1)	 i7 (2)	    i9 (3)
         // 8 RAM (1)	 USD 800	 USD 900	USD 1200
         // 16 RAM(2)	 USD 900	 USD 1000	USD 1400
         // 32 RAM(3)	 USD 1000    USD 1400	USD 2000

         //  Además, el equipo viene con un disco que permite almacenar 500 GB de información 
         //  y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo adicional de 
         //  USD 300. Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, 
         //  y si extiende el disco o no (ingresa 1 para extender o un 0 para no extender) 
         //  y calcule y emita por pantalla el monto de la máquina seleccionada.

            int procesador, memoria, disco, precio = 0;

            Console.WriteLine("Ingrese la opcion de procesador:");
            procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la opcion de memoria:");
            memoria = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Extiende el disco?");
            disco = int.Parse(Console.ReadLine());

            if(procesador == 1){
                switch(memoria)
                {            
                    case 1:
                        precio = 800;
                        break;
                    case 2:
                        precio = 900;
                        break;
                    default:
                        precio = 1000;
                    break; 
                }
            }
            else if(procesador == 2){
                switch(memoria)
                {            
                    case 1:
                        precio = 900;
                        break;
                    case 2:
                        precio = 1000;
                        break;
                    default:
                        precio = 1400;
                    break; 
                }
            }  
            else if(procesador == 3){
                switch(memoria)
                {
                    case 1:
                        precio = 1200;
                        break;
                    case 2:
                        precio = 1400;
                        break;
                    default:
                        precio = 2000;
                    break; 
                }
            }  

            if(disco == 1)
            precio = precio + 300;
         
            Console.WriteLine("El precio final de la compu es: " + precio);        

            //Dependiendo del tipo de procesador que elijas, vas a EVALUAR, el valor de la variable Memoria entre diferentes casos, cases.
            //evaluar seria determinar el valor de algo entre diferentes opciones)

        }   
    }
}
 