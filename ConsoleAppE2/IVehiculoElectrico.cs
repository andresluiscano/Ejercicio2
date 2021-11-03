using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppE2
{
    interface IVehiculoElectrico : IVehiculo
    {
        void ArrancarVehiculo();
        void EncenderLuces();
        void HacerSonarBocina();
    }
}
