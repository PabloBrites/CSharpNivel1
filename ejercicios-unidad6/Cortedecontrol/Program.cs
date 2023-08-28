using System;

namespace Cortedecontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            //CORTE DE CONTROL
            //legajo, edad, sueldo, codigo de equipo numerico (numerico)
            int legajo, edad, codigoEquipo;
            float sueldo;
            int equipoActual;

            //codigos de equipo
            //1 river
            //2 boca
            //3 racing

            Console.WriteLine("Ingrese el legajo:");
            legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad:");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo:");
            sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el codigo de equipo:");
            codigoEquipo = int.Parse(Console.ReadLine());
            //aca podemos tener inicializaciones, contadores, acumuladores, banderas.
            while(sueldo > 0) //con sueldo negativo corta el lote
            {   
                equipoActual = codigoEquipo;
                while (codigoEquipo == equipoActual)
                {
                    // aca procesamos...
                    
                    Console.WriteLine("Ingrese el legajo:");    //el sublote va a cambiar cuando cambie el equipo
                    legajo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la edad:");
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sueldo:");
                    sueldo = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el codigo de equipo:");
                    codigoEquipo = int.Parse(Console.ReadLine());
                
                    //aca se puede mostrar resultados... vos podes mostrar resultados que proceses para cada registro
                    //dentro del while chico
                }
                //mostrar lo que se necesite mostrar... podes mostrar resultados que se procesen para cada sublote, en este
                //caso para cada equipo, afuera, cuando terminaste de procesar todo ese equipo
            }   
            //aca tambien se puede mostrar resultados... o podes mostrar afuera de todo, afuera del while grande cuando 
            //terminaste de procesar todos los equipos podes mostrar algo ej, el mayor sueldo de todos. 
        }
    }
}

//funcionamiento:

//en el ejemplo anterior teniamos equipos de futbol asi que aca vamos a seguir con el mismo ejemplo, hagamos equipos de 
//futbol en el cual se cargue legajo, edad, y sueldo, siempre tenemos que saber como va a trabajar mi corte de control
//en este caso yo puedo decir cargar la informacion de todos los equipos de futbol (agrupados) en donde los datos tienen 
//que ingresar agrupados por equipo de futbol, y para eso se va a crear la variable codigoEquipo,(si la consigna te dice
//que van a estar agrupados por algun parametro ese dato tiene que estar dentro de los datos que forman el registro, en
//este caso el registro esta conformado por el legajo, la edad, el sueldo, y el codigo de equipo)

//el programa va a cortar cuando el (sueldo) sea negativo
//con sueldo negativo corta el lote
//el sublote va a cambiar cuando cambie el equipo
//si cargamos otro dato de repente por ejemplo la antiguedad lo podemos mostrar para cada persona dentro del while chico

//una vez que cargamos los datos ¿cuando va a cortar el lote completo? corta con sueldo negativo, entonces mientras
//el sueldo sea mayor a cero yo voy a seguir cargando datos, y despues voy a seguir cargando depende de la agrupacion que
//tenga si vos tenes en este caso agrupado por equipo, la agrupacion va a ser entonces por el codigo de equipo, entonces
//hay que entender como funciona la variable de equipoActual, la variable equipoActual va a ser el parametro con el que
//yo voy a validar en el while chico, yo voy a procesar mientras el codigo de equipo (codigoEquipo) que vos le ingreses 
//a la persona dentro del while chico. mientras el codigo de equipo sea igual al equipo actual, quiere decir que vos estas
//cargando una persona del mismo equipo

//¿y como se cual es el equipo actual? porque si ingresaste datos validos para procesar lo primero que vamos a hacer 
//antes de que arranque el while chiquito es decir che! el equipo actual es el codigo de equipo >>>>>
//equipoActual = codigoEquipo; y esta es la magia, esta asignacion hace la diferencia de que pasemos de un ciclo combinado
//comun de while con while, a que pasemos de un ciclo combinado con corte de control esta asignacion es la clave,
//obviamente combinado con toda la estructura y combinado con que luego vos preguntas por esta asignacion.

//PREGUNTA MAGICA mientras el codigo de equipo sea igual al equipo actual.

//funcionamiento:

//empezamos cargando el equipo boca, (codigodeequipo 2) comonzamos cargando legajo, edad, sueldo, y su codigo de eqipo que
// va a ser 2.

//luego pregunta ¿sueldo mayor? while (sueldo > 0) si el sueldo es valido sigue

//el equipo actual te dice es el que acabas de cargar osea el 2 equipoActual = codigoEquipo;
// despues te pregunta ¿che! es el mismo? while (codigoEquipo == equipoActual) y si porque lo acabamos de cargar
//entonces entra, cuando entra, calcula cosas que tenga que calcular puede ir cargando maximo o minimo lo que sea
//por ahora no tenemos consigna pensada esto es solo para entender la estructura de corte de control.

//entonces una vez que entra y calcula todo lo que tenga que calcular antes de concluir TE VUELVE A PEDIR UN REGISTRO,
//osea te vuelve a pedir todos los datos otra vez, incluido, el codigo de equipo, cuando llega al fin del while, pregunta
//en el while, y que pregunta? pregunta, si el codigo de equipo de la persona que acabas de cargar ¿es igual al equipo
//actual? ACORDATE que el codigo de equipo actual vos lo asignas una sola vez, antes de empezar a procesar el equipo
//del while chiquito.

//entonces si en el while chiquito se cargo una persona con el codigo de equipo de boca esto va a dar verdadero 
// while (codigoEquipo == equipoActual)
//entonces va a entrar y va a procesar nuevamente, y si vuelvo a cargar otra persona con sus datos, su legajo, su sueldo,
//su edad, y se vuelve a poner el equipo de boca, el while va seguir cargando personas del equipo de boca siempre y cuando 
//cada vez que ingrese los datos de dichas de una personas estas sigan teniendo el mismo numero de equipo.

//ahora supongamos que venimos cargando y se nos pide que carguemos una persona con el codigo 3, cargamos, termina el ciclo
//y vuelve a preguntar, che, el codigo de equipo sigue siendo el codigo de equipo actual? while (codigoEquipo == equipoActual)
// no, porque el equipo actual era el 2, y nosotros cargamos el 3, entonces cancela todo lo que esta dentro del while chico
//procesa y muetra lo que tenga que mostrar, llega al final del while, y pregunta si el sueldo while(sueldo > 0) es positivo
//si el sueldo es positivo es porque cargue una persona con un nuevo codigo de equipo y deseo seguir procesando si el sueldo
//es negativo es porque quiero cancelar todo.

//entonces llega hasta aca while (sueldo > 0) y vuelve a entrar
// y ACTUALIZA EL EQUIPO, porque te dice termine de trabajar con el equipo 2, ahora voy a trabajar con el equipo 3 y te 
//pregunta... el codigo de equipo que tenes cargado en la persona ultima que cargaste y que hizo que terminemos el proceso
//del grupo anterior es el quipo actual? si, ahora si, entonces cargo para racing y mientras yo cargue el codigo 3 voy a 
//seguir cargando para racing.

//cuando cargue el codigo 1, va a terminar, va a terminar, va a preguntar, si es valido entra, actualiza el equipo,
//pregunta, y empieza a procesar para el siguiente equipo, y asi todos los equipos que quieras, y cuando quieras terminar
//el negativo en el sueldo va a hacer que salgas del programa.



