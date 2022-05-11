using Camilla.Interfaces;
using Camilla.Interfaces.Implementations;
using Camilla.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camilla
{
    public class Car : Vehicle
    {
        private string registrationNumber;
        private string registrationYear;

        private Wheel[] wheels;
        private IEngine engine;
        private Gearbox gearbox;

        public void Start()
        {
            
        }

        protected override void TurnLeft(float degrees)
        {
            
        }

        private void CreateWheels()
        {
            wheels = new Wheel[4];
            wheels[0] = new Wheel();
            wheels[1] = new Wheel();
            wheels[2] = new Wheel();
            wheels[3] = new Wheel();
        }

        internal Car(IGasolineEngine engine)
        {
            this.engine = engine;
            gearbox = new Gearbox();
            CreateWheels();
        }

        public Car(string color)
        {
            CreateWheels();
        }

        public Car(string color, float size)
        {
            CreateWheels();
        }
    }
}
