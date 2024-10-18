using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTask
{
    internal class Bicycle : Vehicle
    {
        public string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public override string DefineNatureHarmness()
        {
            return "None";
        }

        public override string GetInfo()
        {
            base.GetInfo();
            return string.Concat(base.GetInfo()+" "+$"Type:{Type}");
        }
        public override string ToString()
        {
            base .ToString();
            return string.Concat(base.ToString() + " " + $"Type:{Type}");
        }
    }
}
