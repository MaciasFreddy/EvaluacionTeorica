using System;

namespace PruebaSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(Singleton.InstanciaClase.Tipo);

            // aqui por medio de la instancia se va a enviar a imprimir los tipos de carros a traves del objeto
            Singleton.InstanciaClase.Tipo = "Carros Electricos";
            Console.WriteLine(Singleton.InstanciaClase.Tipo);

            Singleton.InstanciaClase.Tipo = "Carros Gasolina";
            Console.WriteLine(Singleton.InstanciaClase.Tipo);

            Singleton.InstanciaClase.Tipo = "Carros Diesel";
            Console.WriteLine(Singleton.InstanciaClase.Tipo);
        }
    }
}
