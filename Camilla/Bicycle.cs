using Camilla.Interfaces;
using Camilla.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camilla
{
    public class Bicycle : IBreakable
    {
        private string registrationNumber;
        private Wheel[] wheels;

        public Bicycle(int numberOfWheels, Wheel[] wheels)
        {
            this.wheels = wheels;
        }

        public void Break()
        {
            throw new NotImplementedException();
        }
    }
}
