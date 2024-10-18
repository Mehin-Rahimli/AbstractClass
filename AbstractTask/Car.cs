using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTask
{
    internal class Car : Vehicle
    {
        private int _doorcount;
        private bool _iselectriccar;
        public int DoorCount
        {
            get { return _doorcount; }
            set { _doorcount = value; }
        }
        public bool IsElectricCar
        {
            get { return _iselectriccar; }
            set { _iselectriccar = value; }

        }

        public override string DefineNatureHarmness()
        {
            if (IsElectricCar == true)
            {
                return "Low";
            }
            else
            {
                return "High";
            }
        }

        public override string GetInfo()
        {
            base.GetInfo();
            return string.Concat(base.GetInfo() + " " + $"Qapi sayi:{DoorCount},IsElectricCar:{IsElectricCar}");
        }
        public override string ToString()
        {
             base.ToString();
            return string.Concat(base.ToString() + " " + $"Qapi sayi:{DoorCount},IsElectricCar:{IsElectricCar}");
        }
    }
}
