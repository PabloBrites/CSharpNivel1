using System;
using System.Linq.Expressions;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
            //Se pide determinar e informar:
            //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.   

            int n, conNumeros, conImpares, grupoImparesMaximo = 0, min, conOrdenados = 0;
            double porcentajeImpares, porcentajeMaximo=-1;
            bool banderaOrdenados;

            for (int x = 0; x < 3; x++)
            {   
                conNumeros = 0;
                conImpares = 0;
                banderaOrdenados = true;
                n = int.Parse(Console.ReadLine());
                min = n;
                while(n != 0)
                {
                    conNumeros++;
                    if(n % 2 != 0)
                        conImpares++;
                    
                    if(n <= min)
                        min = n;
                    else
                        banderaOrdenados = false;

                    n = int.Parse(Console.ReadLine());  
                }
                porcentajeImpares = conImpares * 100 / conNumeros;
                if(porcentajeImpares > porcentajeMaximo){
                    porcentajeMaximo = porcentajeImpares;
                    grupoImparesMaximo = x + 1;
                }

                if(banderaOrdenados)
                    conOrdenados++;
            }

            Console.WriteLine("El grupo con mayor porcentaje de impares es: " + grupoImparesMaximo);
            Console.WriteLine("La cantidad de grupos con nros ordenados es: " + conOrdenados);
        }  
    }   
}

//explicacion del ejercicio:

//bien, para arrancar a entender este ejercicio hay que ir armandolo por partes, veamos lo que dice la consigna: la 
//consigna nos dice que disponemos de una lista de 5 listas de numeros enteros separados entre ellos por ceros, esto 
//lo vimos en el curso cuando hablamos de ciclo while ¿como hacemos una lista de numeros que corte con un cero? 

// int n;

// n = int.Parse(Console.ReadLine());
// while(n != 0){

// n = int.Parse(Console.ReadLine();)
// }

// el programa que acabamos de hacer nos permite hacer una lista de numeros que corta con cero, 1 sola lista, pero la 
//consigna nos pide 5 listas de numeros separadas entre ellas por cero, lo que podemos interpretar como 5 listas de numeros
//donde cada lista corta con cero verdad? y como hacemos eso? tendriamos que hacer que el programa que hicimos recien se
//ejecute 5 veces, y para ello vamos a usar un ciclo for y meter el while adentro del for.

//int n;

//for (int x = 0; x < 5; x++) 
//{
    
    //n = int.Parse(Console.ReadLine());
    //while(n != 0){

       //n = int.Parse(Console.ReadLine();)
    //}
//}

//bien, ahora al meter el while adentro del for se van a ingresar numeros y cuando el usuario ponga un numero cero, el while
// va a preguntar si ese numero que ingresaste es distinto de cero (n != 0), como es igual, va a cortar, sale del while e
//incrementa una vuelta del for, pregunta si x < 5 y si es menor entra, pide un numero, si ese numero es distinto de cero
//entra y se vuelven a ingresar numeros hasta que el usuario vuelva a ingresar un cero, asi 5 veces, por lo cual aca ya 
//tenemos resuelta la parte de la lista de 5 listas de numeros enteros separados entre ellos por ceros.

//perfecto, ahora tenemos que resolver los puntos las consignas que me estan planteando, la primera dice: el numero de 
//de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo, entonces primero
//lo que yo tengo que hacer es saber el porcentaje de impares de cada grupo, para yo despues saber el mayor porcentaje 
//de esos numeros 

//regla de 3 simples para porcentajes

//conNumeros -> 100%    maxi dice, si contador de numeros es el 100%
//conImpares -> X=?     entonces el contador de impares que porcentaje representa? 
//como seria la cuenta? conImpares * 100 / conNumeros; 

//ejemplo: primero que nada hay que acordarse que el contador suma DE A UNO, PERO NO ACUMULA LAS CANTIDADES, si se ingresan 
//dos numeros primos por ejemplo el 25 y 27, el contador va a guardar 2 numeros, osea (2 = contador) osea no los va a sumar
//y te va a dar 52, va a contar solo la cantidad de numeros que se ingresaron. 

//en este caso el (conImpares) va a contar los impares, y se van a multiplicar por 100, y luego se van a dividir por la 
//cantidad TOTAL de todos los numeros que se contaron en el (conNumeros) ACORDATE que el conNumeros cuenta tambien de a
//UNO la cantidad total de numeros que se ingresan en el grupo ya sean pares o impares. 

//bien, yo haciendo esto voy a obtener el porcentaje de impares del grupo, pero yo quiero saber cual es el porcentaje  
//mayor, por ahora ya tenemos el total de numeros que forman el grupo conNumeros++, ya tenemos la cantidad de impares que
//forman el grupo conImpares++; y ya tenemos el porcentaje de numeros impares de un grupo porcentajeImpares; ahora lo que
//tengo que saber es si ese porcentaje de impares es el maximo, porque la consigna nos dice el maximo porcentaje de impares
//igualmente la consigna nos pide EL GRUPO, cuyo porcentaje de impares sea el maximo, ok, pero yo para poder averiguar
//cual es el grupo, primero voy a tener que averiguar cual es el porcentaje maximo, y de la mano a que yo a averigue cual
//es el porcentaje maximo voy a saber cual es EL GRUPO, veamos...

// vamos a preguntar asi, si(if) el porcentaje de impares(porcentajeImpares) es mayor al porcentaje maximo? quiere decir 
//que el porcentaje maximo (porcentajeMaximo) tiene que ser este que acaba de ganar, osea el que que acabo de calcular, que
//acaba de ganarle en el if, tiene que combertirse en el porcentaje maximo, y entonces? quien es? quien es el grupo dueño
//del porcentaje maximo? el que acaba de ganar por eso se fue al verdadero sino se hubiera ido por el falso, entonces aca 
//maxi se crea otra variable, (grupoImparesMaximo) y el grupo de impares maximo va a ser, el grupo que yo estoy procesando
//en este momento, y quien me dice cual es el grupo que yo estoy procesando en este momento? ME LO DICE EL CICLO FOR, porque
//el for es el que nos manda los grupos, en este caso de 0 al 5 o mejor dicho De 0 a x-1.

// para entenderlo mejor una vez que termina el while se calcula el porcentaje y te pregunto si ese porcentaje es mayor
//al maximo, si es mayor al maximo la primera vez va a ser porque es el primer grupo, entonces en la primera vuelta en 
// porcentajeMaximo se va a asignar el valor que tenga el primer grupo, pero cuando este procesando otro grupo si es mayor
// al maximo va a ser porque le ah ganado a otro grupo que se guardo antes, y quien le gano a ese grupo que se guardo antes?
//el (porcentajeImpares) y este porcentaje de quien es? este porcentaje es del grupo que acaba de concluir, y este grupo
//que acaba de concluir cual grupo es? y eso me lo determina la x del for

// asi queda:   //porcentajeImpares = conImpares * 100 / conNumeros;
                //if(porcentajeImpares > porcentajeMaximo){
                //porcentajeMaximo = porcentajeImpares;
                //grupoImparesMaximo = x + 1; esto porque los grupos van de 0 a 4 y para la persona que usa esto es de 1 a 5

//una vez que se termina de procesar todo vamos a mostrar:
//Console.WriteLine("El grupo con mayor porcentaje de impares es: " + grupoImparesMaximo);
//y aca ya tendriamos el primer punto.

//en el segundo punto nos pide informar cuantos grupos estan formados por todos numeros ordenados de mayor a menor
//es decir cuantos de esos grupos tienen sus elementos internos ordenados, ¿y yo como se si esos elementos estan ordenados?
//bueno aca hay que jugar a la busqueda de un MIN, MINIMO. me voy a tener que guardar el primer valor y de ahi empezare
//a preguntar si el siguiente es menor y asi sucesivamente, osea si  el siguiente es menor actualizo el menor y asi va 
//bajando y tambien vamos a jugar con una BANDERA. y cuando encuentre un numero que no sea menor al anterior quiere decir
//que los numeros no fueron de mayor a menor en ese grupo. y ahi vamos a cancelar con una bandera. con la bandera vamos 
//a marcar si los numeros estan ordenados o no estan ordenados.

//bueno para arrancar lo que tenemos que hacer es crear una variable que establesca el elemento inicial, la vamos a llamar
//MIN, porque yo quiero saber si estan ordenados de mayor a menor entonces yo voy a ir preguntando cada vez con el MIN, Y 
//lo vamos a inicializar aca  conNumeros = 0;
//                            conImpares = 0;
//                            banderaOrdenados = true;
//                            n = int.Parse(Console.ReadLine());
//                            min = n;                              <<-----

//osea antes del while CON EL PRIMER ELEMENTO INGRESADO, esto ya me asegura el primer elemento ingresado del grupo en cuestion
//y cuando esto llegue al fin del for y vuelva a comenzar va a comenzar un nuevo ciclo, un nuevo grupo, una nueva lista,
//y nosotros vamos a  tener el primer elemento inicializado en min = n;

//para realizar la busqueda del MIN vamos a hacer esto //  if(n <= min)
                                                        //    min = n;
// aca preguntamos si el numero ingresado es menor al minimo entonces el minimo es n
//¿y la bandera donde entra?
//la bandera entra aca, primero vamos a crear un tipo de dato bool, bool banderaOrdenados;

//y la vamos a inicializar en true pero la vamos a inicializar aca  //conNumeros = 0;
                                                                    //conImpares = 0;
                                                                    //banderaOrdenados = true;

//porque la vamos a inicializar en true? porque voy a ASUMIR que los valores estan ordenados ENTONCES YO DIGO BANDERA 
//DE ORDENADOS ESTA ACTIVA, los valores estan ordenados, se pide el primer numero, guardo el primer numero, pido otro
// si es menor actualizo, cuando termina este ciclo yo voy a preguntar si LA BANDERA ESTA EN TRUE, si la bandera esta 
// en true ese grupo esa lista tiene sus elementos ordenados, ya que todos los numeros que fueron ingresando fueron uno mas
//menor que el otro, ahora, cuando voy a saber yo que esta desordenado? cuando por una unica vez haya venido por el false
// la bandera de ordenados va a quedar en falso asi: //   if(n <= min)
                                                     //       min = n;
                                                     //   else
                                                     //       banderaOrdenados = false

//entonces que yo haya puesto la bandera en falso una vez, ya a mi me alcanza para saber que ese grupo esta desordenado
//una vez que se ingreso un numero mayor al minimo ya no nos importa nada, la bandera de ordenados se va a poner en false
//la primera vez que se encuentre con un numero mayor al minimo se activa en false la bandera y ya no se puede volver a 
// poner en true nunca mas.

//antes de terminar y concluir con el programa y con esto de la bandera, hay que acordarse que maxi creo un conOrdenados = 0;
//que va a servir para contar la cantidad de grupos con numeros ordenados. 
// y despues va a preguntar // if(banderaOrdenados)
                            //    conOrdenados++;

// esto --> if(banderaOrdenados) seria como preguntar si la bandera de ordenados esta en true, ya que como la bandera de
//ordenados es un valor BOOLEANO, que el booleano es true o false, cuando la bandera este en true se a a ir al true y cuando
//la bandera este en false se va a ir al false. 

//una vez realizados todos los procesos se van a mostrar aca:
//Console.WriteLine("El grupo con mayor porcentaje de impares es: " + grupoImparesMaximo);
//Console.WriteLine("La cantidad de grupos con nros ordenados es: " + conOrdenados);

//fin




