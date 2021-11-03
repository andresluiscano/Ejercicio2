using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppE2
{
    public class Bicicleta: IVehiculo
    {
        public void Avanzar() { Console.WriteLine("La bicicleta avanzó."); }
        public void Frenar() { Console.WriteLine("La bicicleta frenó."); }
    }
}
