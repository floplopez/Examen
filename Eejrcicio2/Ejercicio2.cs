using System;

namespace Examen
{
    public class Ejercicio2
    {
        static void Main(string[] args){
            Console.WriteLine("Hoy es Lunes. Ingrese la temperatura maxima alcanzada hoy, en grados");
            int[] arrayTemp = new int[7];
            arrayTemp [0] = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Hoy es Martes. Ingrese la temperatura maxima alcanzada hoy, en grados");
            arrayTemp [1] = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Hoy es Miercoles. Ingrese la temperatura maxima alcanzada hoy, en grados");
            arrayTemp [2] = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Hoy es Jueves. Ingrese la temperatura maxima alcanzada hoy, en grados");
            arrayTemp [3] = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Hoy es Viernes. Ingrese la temperatura maxima alcanzada hoy, en grados");
            arrayTemp [4] = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Hoy es Sabado. Ingrese la temperatura maxima alcanzada hoy, en grados");
            arrayTemp [5] = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Hoy es Domingo. Ingrese la temperatura maxima alcanzada hoy, en grados");
            arrayTemp [6] = Int32.Parse(Console.ReadLine());

            int temperaturaMax=arrayTemp[0];  
            int temperaturaMin=arrayTemp[0];

            for(int i=0; i<arrayTemp.Length; i++){
                if(temperaturaMax<arrayTemp[i]){
                    temperaturaMax=arrayTemp[i];
                }

                if(temperaturaMin>arrayTemp[i]){
                    temperaturaMin=arrayTemp[i];
                }
            }
            
            int promedio=(temperaturaMax+temperaturaMin)/2;

            Console.WriteLine("La tempatura maxima fue de "+temperaturaMax+"°.");
            
            Console.WriteLine("La tempatura minima fue de "+temperaturaMin+"°.");
            
            Console.WriteLine("La tempatura promedio fue de "+promedio+"°.");

        }
    }
}