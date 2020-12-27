using System;

namespace My_class
{
    [Serializable]
    public class MeteoSystem
    {
        public string SName { get; set; }
        public int SNumber { get; set; }

        public Line Line { get; set; }
        public MeteoSystem()
        { }

        public MeteoSystem(string name, int num, Line line)
        {
            SName = name;
            SNumber = num;
            Line = line;
        }

       
    }

    [Serializable]
    public class Line
    {
        public int LNumber { get; set; }

        public Sensor Sensor { get; set; }
        public Line()
        { }

        public Line(int num, Sensor sensor)
        {
            LNumber = num;
            Sensor = sensor;
        }
        
    }

    [Serializable]
    public class Sensor
    {
        public int Pressure { get; set; }
        public int Viscosity { get; set; }
        public int Density { get; set; }
        public int T { get; set; }
        public int QuantityMax { get; set; }
        public int QuantityMin { get; set; }
        public string ShortName { get; set; }

        public Sensor()
        { }

        public Sensor(int pre, int vis, int den, int t, int qma, int qmi, string name)
        {
            Pressure = pre;
            Viscosity = vis;
            Density = den;
            T = t;
            QuantityMax = qma;
            QuantityMin = qmi;
            ShortName = name;
        }

    }
}
