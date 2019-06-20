using System;

namespace Examen
{
    public class Ejercicio2
    {
        static void Main(string[] args){
            
            float[] arrayDeTemperaturas = new float[7];
            bool validacionNumeroIngresado;
            float temperatura;

            for(int i=0; i<7; i++){

                Console.WriteLine("Dia "+(i+1)+": Ingrese la temperatura maxima alcanzada, en grados");
                
                validacionNumeroIngresado = float.TryParse(Console.ReadLine(),out temperatura);
                    
                if(validacionNumeroIngresado){
                        
                    arrayDeTemperaturas[i] = temperatura;

                }else{
                        
                    Console.WriteLine("Ha ingresado una temperatura invalida");
                }
            }

            float temperaturaMax= float.MinValue;  
            int diaTemperaturaMax=0;
            float temperaturaMin= float.MaxValue;
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
            
            float promedioDeLaSemana=(temperaturaMax+temperaturaMin)/7;

            Console.WriteLine("El dia de mayor temperatura fue el dia "+diaTemperaturaMax);
            
            Console.WriteLine("El dia de menor temperatura fue el dia "+diaTemperaturaMin);
            
            Console.WriteLine("La temperatura promedio fue de "+promedioDeLaSemana+"°.");

            }
        }
    }
