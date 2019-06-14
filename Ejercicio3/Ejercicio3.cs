using System;
using System.Collections.Generic;

namespace examen
{
    public abstract class Personajes
    {
        public string Vivo {get;set;}
        public string QueComen {get;set;}

        public string ComoCaminan {get;set;}

        public string Sonido {get;set;}

        public Personajes(string vivo, string queComen, string comoCaminan, string sonido )
        {
            Vivo = vivo;
            QueComen = queComen;
            ComoCaminan = comoCaminan;
            Sonido = sonido;
        }

        public abstract void ShowData();
    }

    public class Zombie : Personajes 
    {
        public Zombie() : base ("no esta vivo","cerebroos","como zombies..","aggggg!")
        {}

        public override void ShowData(){
            Console.WriteLine("El zombie "+Vivo+", el come "+QueComen+", el camina "+ComoCaminan+", y emite este sonido: "+Sonido);
        }
    }

    public class NoInfectado : Personajes 
    {
        public NoInfectado() : base ("esta vivo","todo menos cerebros!","sin renguear","Que onda!")
        {}

        public override void ShowData(){
            Console.WriteLine("El humano no infectado "+Vivo+", el come "+QueComen+", el camina "+ComoCaminan+", y emite este sonido: "+Sonido);
        }
    }

    public class Ejercicio3
    {
        static void Main(string[] args){

            Zombie zombie1 = new Zombie();
            NoInfectado noinfectado1 = new NoInfectado();

            List <Personajes> personajes =new List<Personajes>();
            personajes.Add(zombie1);
            personajes.Add(noinfectado1);

            foreach (Personajes personaje in personajes)
            {
                zombie1.ShowData();
                noinfectado1.ShowData();
            }
        }
    }
}