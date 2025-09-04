using Practica_POO_CS;
using System;
using System.Collections.Generic;

public class Arch_main
{
    public static void Main(string[] args)
    {
        //Instanciar objetos /*PESO, ENERGIA, RESISTENCIA, AGILIDAD, IQ, +ATRIBUTO*/
        Perro firulais = new Perro(25.0, 90, 20.0, 60, 50, 400);
        Gato michi = new Gato(10.0, 70, 10.0, 80, 90, 150);
        Humano lucas = new Humano(80.0, 95, 30.0, 85, 115, 120);
        

        //Acciones
        firulais.Ladrar();
        michi.Maullar();
        lucas.Hablar();

        System.Console.WriteLine($"\nEl Perro corre a una velocidad de {firulais.Correr()} km/h. Salta a una altura de {firulais.Saltar()} m. Y Ataca {firulais.Atacar()} de daño.");
        System.Console.WriteLine($"El Gato corre a una velocidad de {michi.Correr()} km/h. Salta a una altura de {michi.Saltar()} m. Y Ataca {michi.Atacar()} de daño.");
        System.Console.WriteLine($"El Humano corre a una velocidad de {lucas.Correr()} km/h. Salta a una altura de {lucas.Saltar()} m. Y Ataca {lucas.Atacar()} de daño. \n");
        
        Ser_Vivo[] seres = { firulais, michi, lucas };
        foreach (Ser_Vivo ser in seres)
        {
            ser.Comunicar();
        }

        //Pausar la consola
        System.Console.ReadKey();
    }
}