using System;
using System.Collections.Generic;
using System.Text;

namespace Camilla
{
    public class Factory
    {
        private List<Vehicle> _vehicles;

        public static void Instance()
        {

        }

        private Factory()
        {

        }

        public Vehicle Create(int type)
        {
            return null;
        }
    }
}
