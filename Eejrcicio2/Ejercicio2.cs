using System;

namespace Examen
{
    public class Ejercicio2
    {
        static void Main(string[] args){
            
            decimal[] arrayDeTemperaturas = new decimal[7];
            bool validacionNumeroIngresado;
            decimal temperatura;

            for(int i=0; i<7; i++){

                Console.WriteLine("Dia "+(i+1)+": Ingrese la temperatura maxima alcanzada, en grados");
                
                validacionNumeroIngresado = decimal.TryParse(Console.ReadLine(),out temperatura);
                    
                if(validacionNumeroIngresado){
                        
                    arrayDeTemperaturas[i] = temperatura;

                }else{
                        
                    Console.WriteLine("Ha ingresado una temperatura invalida");
                }
            }

            decimal temperaturaMax= decimal.MinValue;  
            int diaTemperaturaMax=0;
            decimal temperaturaMin= decimal.MaxValue;
            int diaTemperaturaMin=0;

            for(int i=0; i<7; i++){

                if(temperaturaMax<=arrayDeTemperaturas[i]){
                    temperaturaMax=arrayDeTemperaturas[i];
                    diaTemperaturaMax=i+1;
                }

                if(temperaturaMin>arrayDeTemperaturas[i]){
                    temperaturaMin=arrayDeTemperaturas[i];
                    diaTemperaturaMin=i+1;
                }
            }
            
            decimal promedioDeLaSemana=(temperaturaMax+temperaturaMin)/7;

            Console.WriteLine("El dia de mayor temperatura fue el dia "+diaTemperaturaMax);
            
            Console.WriteLine("El dia de menor temperatura fue el dia "+diaTemperaturaMin);
            
            Console.WriteLine("La temperatura promedio fue de "+promedioDeLaSemana+"°.");

            }
        }
    }
