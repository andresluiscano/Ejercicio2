using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppE2
{
    public class MonopatinElectrico:IVehiculoElectrico
    {
        public void ArrancarVehiculo() { Console.WriteLine("El monopatin arrancó."); }
        public void Avanzar() { Console.WriteLine("El monopatin avanzó."); }
        public void Frenar() { Console.WriteLine("El monopatin frenó."); }
        public void EncenderLuces() { Console.WriteLine("El monopatin encendió las luces."); }
        public void HacerSonarBocina() { Console.WriteLine("El monopatin hizo sonar la bocina."); }
    }
}
