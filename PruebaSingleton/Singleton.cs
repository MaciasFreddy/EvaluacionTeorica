using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSingleton
{
    class Singleton
    {
        private static Singleton problema = null;

        public static Singleton InstanciaClase   // este es un metodo  que retorna la instancia en caso de que no halla.
        {
            get
            {
                if (problema == null)
                {
                    problema = new Singleton();
                }
                return problema;
            }
        }

        public string Tipo = ""; // este es una propiedad 
        public Singleton()  // este es el constructor de la clase
        {
            Tipo = "Tipos De Carros";  // aqui enviamos el tipo de carro que va a imprimir
        }
    }
}
