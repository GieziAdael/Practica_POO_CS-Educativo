using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_POO_CS
{
    public class Ser_Vivo
    {
        //Atributos
        protected double peso { get; set; }
        protected int energia { get; set; }
        protected double resistencia { get; set; }
        protected int agilidad { get; set; }
        protected int iq { get; set; }

        //Constructor
        public Ser_Vivo(double peso, int energia, double resistencia, int agilidad, int iq)
        {
            this.peso = peso;
            this.energia = energia;
            this.resistencia = resistencia;
            this.agilidad = agilidad;
            this.iq = iq;
        }

        //Metodos

        public virtual void Comunicar()
        {
            Console.WriteLine("El ser vivo emite un sonido...");
        }
        public double Correr()
        {
            double velocidad;
            return velocidad = ((energia / peso) * agilidad)/10;
        }
        public double Saltar()
        {
            double altura;
            return altura = ((energia / peso) * resistencia)/10;
        }
        public double Atacar()
        {
            double daño;
            return daño = (energia * peso * agilidad + (iq))/1000;
        }
    }

    public class Perro : Ser_Vivo
    {
        //Atributos
        public double mordedura { get; set; }

        //Constructor
        public Perro(double peso, int energia, double resistencia, int agilidad, int iq, double mordedura) : base(peso, energia, resistencia, agilidad, iq)
        {
            this.mordedura = mordedura;
        }

        //Metodos
        public override void Comunicar()
        {
            Console.WriteLine("El perro ladra");
        }
        public void Ladrar()
        {
            double volumen = energia * agilidad * iq + (mordedura);
            System.Console.WriteLine("El perro ladra con un volumen de: " + volumen);
        }
    }

    public class Gato : Ser_Vivo
    {
        //Atributos
        public double sigilo { get; set; }
        //Constructor
        public Gato(double peso, int energia, double resistencia, int agilidad, int iq, double sigilo) : base(peso, energia, resistencia, agilidad, iq)
        {
            this.sigilo = sigilo;
        }
        //Metodos
        public override void Comunicar()
        {
            Console.WriteLine("El gato maúlla");
        }
        public void Maullar()
        {
            double volumen = energia * agilidad * iq + (sigilo);
            System.Console.WriteLine("El gato maulla con un volumen de: " + volumen);
        }
    }

    public class Humano : Ser_Vivo
    {
        //Atributos
        public double fuerza { get; set; }
        //Constructor
        public Humano(double peso, int energia, double resistencia, int agilidad, int iq, double fuerza) : base(peso, energia, resistencia, agilidad, iq)
        {
            this.fuerza = fuerza;
        }
        //Metodos
        public override void Comunicar()
        {
            Console.WriteLine("El humano hace sonidos extraños.");
        }
        public void Hablar()
        {
            double volumen = energia * agilidad * iq + (fuerza);
            System.Console.WriteLine("El humano habla con un volumen de: " + volumen);
        }
    }
}
