using System;
using System.Collections.Generic;


namespace examen
{
    public abstract class Personajes
    {
        public string Vivo {get;set;}

        public Personajes(string vivo)
        {
            Vivo = vivo;
        }

        public abstract void ShowData();
        public abstract void Comer();
        public abstract void Caminar();
        public abstract void Hablar();
    }

    public class Zombie : Personajes 
    {
        public Zombie() : base ("muerto")
        {}

        public override void ShowData(){
            Console.WriteLine("El zombie está "+Vivo);
        }
        public override void Comer(){
            Console.WriteLine("El zombie come cerebros humanos");
        }
        public override void Caminar(){
            Console.WriteLine("El zombie camina como... zombie");
        }
        public override void Hablar(){
            Console.WriteLine("El zombie dice 'Aaaarggghh!'");
        }
    }

    public class NoInfectado : Personajes 
    {
        public NoInfectado() : base ("vivo")
        {}

        public override void ShowData(){
            Console.WriteLine("El no infectado está "+Vivo);
        }
        public override void Comer(){
            Console.WriteLine("El no infectado no come cerebros humanos");
        }
        public override void Caminar(){
            Console.WriteLine("El no infectado camina erguido");
        }
        public override void Hablar(){
            Console.WriteLine("El no infectado dice 'Hola!'");
        }
    }

    public class Ejercicio3
    {
        static void Main(string[] args){

            Zombie zombie1 = new Zombie();
            Zombie zombie2 = new Zombie();
            NoInfectado noinfectado1 = new NoInfectado();

            List <Personajes> personajes =new List<Personajes>();
            personajes.Add(zombie1);
            personajes.Add(zombie2);
            personajes.Add(noinfectado1);

            foreach (Personajes personaje in personajes)
            {
                zombie1.ShowData();
                zombie1.Comer();
                zombie1.Caminar();
                zombie1.Hablar();

                zombie2.ShowData();
                zombie2.Comer();
                zombie2.Caminar();
                zombie2.Hablar();

                noinfectado1.ShowData();
                noinfectado1.Comer();
                noinfectado1.Caminar();
                noinfectado1.Hablar();
            }
        }
    }
}
//en vez de lista en el program, podria hacer un array. Recorriendolo por un for: personaje[i].detalle(); podria ser 
//un .metedo por cada metodo
//Como propiedad--> bool EstaVivo; 
//Como metodo --> void Detalle(){con.wl(EstaVivo)}
//{con.wl(Comer)}
//{con.wl(CAminar)}
//{con.wl(Hablar)}
//public abstract comer();
//public abstract camianr();
//public abstract hablar();
