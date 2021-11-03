using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppE2
{
    interface IVehiculoConRadio : IVehiculoElectrico
    {
        void EncenderRadio();
        void ApagarRadio();
    }
}
