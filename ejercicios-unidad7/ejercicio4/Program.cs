using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba 
            //un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por 
            //referencia con:

            //a. 1 si el número es positivo.
            //b. -1 si el número es negativo.
            //c. 0 si el número es cero.

            //En resumen, en el entorno de desarrollo de Visual Studio, puedes pensar en la ventana de "Salida" 
            //como una especie de consola simulada, pero en el contexto del sistema operativo, la consola se refiere 
            //más a la interfaz de línea de comandos tradicional que puedes abrir en Windows, Linux, o macOS.

            int n1, H = 0;

            Console.WriteLine("Ingrese un Numero:");
            n1 = int.Parse(Console.ReadLine());

            PositivoNegativoCero(n1, ref H);

            Console.WriteLine(H);

        }

        static void PositivoNegativoCero(int N, ref int H){

            if(N > 0)
                H = 1;
            else if(N < 0)
                H = -1;
            else
                H = 0;
            
        }
    }
}
