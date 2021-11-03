using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppE2
{
    public class Auto:IVehiculoConRadio
    {
        public void ArrancarVehiculo() { Console.WriteLine("El auto arrancó."); }
        public void Avanzar() { Console.WriteLine("El auto avanzó."); }
        public void Frenar() { Console.WriteLine("El auto frenó."); }
        public void EncenderRadio() { Console.WriteLine("El auto encendió la radio."); }
        public void ApagarRadio() { Console.WriteLine("El auto apagó las luces."); }
        public void EncenderLuces() { Console.WriteLine("El auto encendió las luces."); }
        public void HacerSonarBocina() { Console.WriteLine("El auto hizo sonar la bocina."); }
    }
}
