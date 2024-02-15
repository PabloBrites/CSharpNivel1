using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            // Número de Artículo (1 a 15)
            // Cantidad Vendida

            // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            // Se pide determinar e informar:
            // a) El número de artículo que más se vendió en total.
            // b) Los números de artículos que no registraron ventas.
            // c) Cuantas unidades se vendieron del número de artículo 10.

            int nroArticulo;
            int cantidad;
            int totalCantidadVendida = new int[15]; //este es el vector de acumuladores

            for (int x = 0; x < 15; x++)
            {
                totalCantidadVendida[x] = 0;        
            }

            Console.WriteLine("Ingrese el numero de articulo");   
            nroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida");
            cantidad = int.Parse(Console.ReadLine());
            
            while (nroArticulo != 0)
            {
                totalCantidadVendida[nroArticulo - 1] += cantidad;      //<-- la cuestion es en que posicion del vector yo voy a acumular, ¿en que posicion?
                                                                        //    en la posicion del producto, ¿y cual es la posicion? y la posicion puede ser del 0 al 14
                Console.WriteLine("Ingrese el numero de articulo");     //    donde el 0 es la primera y el 14 es la 15, entonces del 0 al 14 como voy a saber ese numero?
                nroArticulo = int.Parse(Console.ReadLine());            //    bueno, ¿que carga la persona en el programa? carga numero de articulo y cantida vendida, y casualmente
                Console.WriteLine("Ingrese la cantidad vendida");       //    el numero de articulo que valor corresponde? a un numero del 1 al 15, entonces, cuando la persona cargue el
                cantidad = int.Parse(Console.ReadLine());               //    numero de producto 1, yo voy a tener que acumular en el elemento 0, si carga el articulo 15, yo voy a tener que acumular 
                                                                        //    en el elemento 14, y cuando cargue otra vez en en el 1 volvere a acumular nuevamente en el 0, etc, entonces yo voy a decir aca que 
            }                                                           //    quiero que me cargue "totalCantidadVendida[nroArticulo - 1]" += cantidad;" en el numero de articulo que me carga la persona -1 menos uno. 
                                                                    
                                                                        //    entonces en cada vez que yo ejecute esto "totalCantidadVendida[nroArticulo - 1]" voy a decir ahh, ¿en que articulo queres cargar vos? ah bueno 
                                                                        //    le resto -1 y eso se transforma en el "en el indice de mi vector" y a ese indice, en esa posicion del vector, le acumulo la cantidad. 


                                                                        // aca tengo que buscar un maximo dentro del vector Y SU POSICION, ¿porque su posicion? ¿porque el maximo? el maximo porque me pide el numero de articulo
                                                                        // que mas se haya vendido, ¿y su posicion porque? y porque que es lo que me va a dar el numero de articulo? del 1 al 15, el indice + 1, la posicion. 
            
            //punto a
            int maxCantidad = totalCantidadVendida[0];                   
            int nroMaximo = 1;
            for (int x = 0; x < 15; x++)                                // esto es la condicion del if --> (si la cantidad de este articulo es mayor a la maxima cantidad, entonces te voy a decir que la maxima cantidad es ese  
            {                                                           // que acaba de ser mayor, el total mayor que acaba de ganar, y el numero maximo de producto es x + 1;    
                if(totalCantidadVendida[x] > maxCantidad){              
                    maxCantidad = totalCantidadVendida[x];
                    nroArticulo = x + 1;
                }
            }
            Console.WriteLine("El producto mas vendido es el: " + nroArticulo + " con la cantidad de: " + maxCantidad);

            
            //punto b 
                                                                        // ¿como se yo si no se registraron ventas? y si no hay ventas no van a cargar nada, mi programa sirve para cargar ventas, si no hubo ventas de un articulo   
                                                                        // significa que no hay registro del mismo, pero yo tengo un vector que acabo de cargar con la cantidad total vendida (totalCantidadVendida), si al terminar de 
                                                                        // cargar las ventas, yo tengo elementos con CERO todavia, quiere decir que esos productos no han tenido ventas, y eso es lo que me pide la consigna
            for (int x = 0; x < 15; x++)
            {
                if(totalCantidadVendida[x] == 0){                       //aca evalua los 15 productos y si no tuvo ventas nos dice cual no tuvo
                    Console.WriteLine("El producto " + (x + 1) + "no tuvo ventas");
                
                }
            }                                                 
            
            //punto c                                                   // la consigna c me dice Cuantas unidades se vendieron del número de artículo 10, yo se cuantas se vendieron? no, pero casualmente llene un vector (totalCantidadVendida) con las 
                                                                        // cantidades vendidas para cada articulo, entonces el punto c va a ser tan sencillo como decir: 
                
            Console.WriteLine("La cantidad vendida del articulo 10 es: " + totalCantidadVendida[9]);    // <-- que le vas a concatenar aca? la cantidad vendida de quien? de totalCantidadVendida, si, pero en que indice? en el 9, porque el 9 corresponde 
                                                                                                        // al elemento 10, 0 es el 1, 1 es el 2, 2 es el 3, 3 es el 4, 4 es el 5, y asi sucesivamente. 
                
                
                // int[] Vacu = new int[15];
                // int ValorIngresado;

                // for (int x = 0; x < 15; x++)
                // {
                //     Console.WriteLine("Ingrese un valor por favor");
                //     ValorIngresado = int.Parse(Console.ReadLine());
                //     Vacu[x] = ValorIngresado;
                // }

                // Console.Write("Los numeros que posee el vector son:");
                // for (int x = 0; x < 5; x++)
                // {
                
                //     Console.Write(Vacu[x]);
                // }

                // pero entonces si yo no creaba una variable "valor ingresado" no podia hacer el traspaso del valor que 
                // ingresa el usuario directamente al vector?
                // ChatGPT
                // Correcto, la creación de la variable ValorIngresado es necesaria en este caso para almacenar 
                // temporalmente el valor que el usuario introduce a través de Console.ReadLine(). 
                // Esta variable actúa como un contenedor temporal para el valor antes de asignarlo a la posición 
                // correspondiente en el vector.
            




        }
    }
}
