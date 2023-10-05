using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int carreraactual, legajoalumno, codigocarrera = 0, codigomaterias;
            int maxcarrera = 0, mincarrera = -1, inscripcionesmaxima, inscripcionesminima = 0, inscripciones;
            char modalidad, horario; 

            Console.WriteLine("Ingresar legajo del alumno:");
            legajoalumno = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese codigo de carrera:");
            codigocarrera = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese codigo de materia:");
            codigomaterias = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese modalidad:");
            modalidad = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su horario:");
            horario = char.Parse(Console.ReadLine());
            
            inscripciones = 0;
            inscripcionesmaxima = 0;
            while (legajoalumno > 0){
                
                  
                carreraactual = codigocarrera;
                while (codigocarrera == carreraactual){ 
                    

                    if(modalidad == 'D'|| modalidad == 'P')
                        inscripciones++;
                    
                        
                
                    Console.WriteLine("Ingresar legajo del alumno:");
                    legajoalumno = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese codigo de carrera:");
                    codigocarrera = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese codigo de materia:");
                    codigomaterias = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese modalidad:");
                    modalidad = char.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese su horario:");
                    horario = char.Parse(Console.ReadLine());

                }              
            
                if(inscripciones > inscripcionesmaxima){
                        inscripcionesmaxima = inscripciones;
                        maxcarrera = carreraactual;
                }
                if((inscripciones < inscripcionesminima && inscripciones > 0) || inscripcionesminima == 0){
                        inscripcionesminima = inscripciones;
                        mincarrera = carreraactual;

                }
                inscripciones = 0;
            
            }
            Console.WriteLine("La carrera con mas inscripciones a la modalidad distancia es :" + maxcarrera);
            Console.WriteLine("La carrera con menos inscripciones es: " + mincarrera);
        }
    }
}