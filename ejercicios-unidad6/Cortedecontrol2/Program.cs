using System;

namespace Cortedecontrol2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerodeproveedor, Dia, Mes, numerodeproducto, cantidadcomprada, proveedoractual, cantmaxima = 0;
            int numeroprovmaximo = 0, monto = 0, facturaA = 0, facturaB = 0, facturaC = 0;
            int preciounitariodelproducto, conCCp, menago = 0, prodmenago = 0;
            char tipodefactura;
            bool bandagomin = true;

            Console.WriteLine("Ingrese el Numero de proveedor:");
            numerodeproveedor = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Dia:");
            Dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Mes:");
            Mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de factura:");
            tipodefactura = Char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de producto:");
            numerodeproducto = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad comprada");
            cantidadcomprada = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio unitario del producto:");
            preciounitariodelproducto = int.Parse(Console.ReadLine());
            
            while(numerodeproveedor != 0){

                proveedoractual = numerodeproveedor;
                conCCp = 0;
                while (numerodeproveedor == proveedoractual)  
                {
                    conCCp++;
                    monto = cantidadcomprada * preciounitariodelproducto;
                    if(monto > cantmaxima){
                    cantmaxima = monto;
                    numeroprovmaximo = numerodeproveedor;
                    }
                        if(tipodefactura == 'A')
                            facturaA += monto;
                        else if (tipodefactura == 'B')
                            facturaB += monto;
                        else if(tipodefactura == 'C')
                            facturaC += monto;                                

                        if(Mes == 8){
                           if(bandagomin == true)
                            menago = monto;
                            bandagomin = false;
                            prodmenago = numerodeproducto;
                        }
                         else if(monto < menago){
                            menago = monto;
                            prodmenago = numerodeproducto;
                        }
                    
                        Console.WriteLine("Ingrese el Numero de proveedor:");
                        numerodeproveedor = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el Dia:");
                        Dia = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el Mes:");
                        Mes = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el tipo de factura:");
                        tipodefactura = Char.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el numero de producto:");
                        numerodeproducto = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la cantidad comprada");
                        cantidadcomprada = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el precio unitario del producto:");
                        preciounitariodelproducto = int.Parse(Console.ReadLine());               
                    
                }
                Console.WriteLine("La cantidad de compras que se realizo a proveedor " + proveedoractual + " fue de: " + conCCp);
            }                        
            Console.WriteLine("El monto maximo registrado en una sola compra fue de: " + cantmaxima + " Numero de proveedor: " + numeroprovmaximo);
            Console.WriteLine("La inversión total de todo el año discriminada por tipo de factura es:");
            Console.WriteLine("Factura A: " + facturaA);
            Console.WriteLine("Factura B: " + facturaB);
            Console.WriteLine("Factura C: " + facturaC);
            Console.WriteLine("La compra de menor monto del mes de agosto fue de: " + menago + "con el numero de producto numero: " + prodmenago);
        }
    }
}
