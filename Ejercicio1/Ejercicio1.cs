using System;

namespace examen
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero positivo y distinto de cero");
            int numeroIngresado = Int32.Parse(Console.ReadLine());
            
            if(numeroIngresado > 0){
                int  cantitdadDeVeces = 1;
                for(int i=1; i<=numeroIngresado; i++){
                cantitdadDeVeces = i;
                } 
                if (cantitdadDeVeces==1){
                Console.WriteLine("El numero ingesado "+numeroIngresado+", se forma sumando "+cantitdadDeVeces+" vez 1");
                }else{
                Console.WriteLine("El numero ingesado "+numeroIngresado+", se forma sumando "+cantitdadDeVeces+" veces 1");
                }
            }else{
                Console.WriteLine("Se ingreso un numero menor o igual a 0");
                }
        }
    }
}
