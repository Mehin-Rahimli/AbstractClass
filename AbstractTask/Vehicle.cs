using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTask
{
    abstract class Vehicle
    {
        private string _factoryname;
        private string _model;
        private string _color;
        private int _drivetime;
        private float _drivepath;

        public string FactoryName { get { return _factoryname; } set { _factoryname = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public string Color { get { return _color; } set { _color = value; } }
        public int DriveTime { get { return _drivetime; } set { _drivetime = value; } }

        public float DrivePath { get { return _drivepath; } set { _drivepath = value; } }

        public void AvarageSpeed()
        {
            float speed = DrivePath / DriveTime;
            Console.WriteLine($"Ortalama suretiniz:{speed}");
        }
        public virtual string GetInfo()
        {
            return$"FactoryName:{FactoryName}, Model:{Model}, Color:{Color}, DriveTime:{DriveTime}, DrivePath:{DrivePath}";

        }
        public override string ToString()
        {
            return $"FactoryName:{FactoryName},Model:{Model}, Color:{Color}, DriveTime:{DriveTime}, DrivePath:{DrivePath}";
        }

        public abstract string DefineNatureHarmness();




    }
}
