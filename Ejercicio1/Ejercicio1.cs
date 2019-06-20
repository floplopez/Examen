using System;

namespace examen
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero positivo");
            string numeroIngresado = Console.ReadLine();
            int numero;
            bool validacionNumero = Int32.TryParse(numeroIngresado, out numero);
            
            if(validacionNumero && numero>0){
                    int respuesta= 0;

                    for(int i=1; i<numero; i++){
                    respuesta += i;

                    }
                    Console.WriteLine("El resultado de la suma de numero/os que antecede al "+numero+" es "+respuesta);

            }
            else{
                Console.WriteLine("Se ingreso un numero invalido o un string");

            }      
        }
    }
}
