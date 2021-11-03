using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppE2
{
    public class Camion : IVehiculoConRadio
    {
        public void ArrancarVehiculo() { Console.WriteLine("El camión arrancó."); }
        public void Avanzar() { Console.WriteLine("El camión avanzó."); }
        public void Frenar() { Console.WriteLine("El aucamiónto frenó."); }
        public void EncenderRadio() { Console.WriteLine("El camión encendió la radio."); }
        public void ApagarRadio() { Console.WriteLine("El camión apagó las luces."); }
        public void EncenderLuces() { Console.WriteLine("El camión encendió las luces."); }
        public void HacerSonarBocina() { Console.WriteLine("El camión hizo sonar la bocina."); }
    }
}
