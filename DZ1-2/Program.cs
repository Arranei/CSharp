using System;
using System.IO;
using System.Xml.Serialization;

using My_class;
// VAR DX1
namespace DZ1_2
{
    class Program
    {
#pragma warning disable IDE0060 // Удалите неиспользуемый параметр
        static void Main(string[] args)
#pragma warning restore IDE0060 // Удалите неиспользуемый параметр
        {
            Sensor TestSensor = new Sensor(1, 2, 3, 4, 5, 6, "Проба");
            Line TestLine = new Line(0, TestSensor);
            MeteoSystem Test = new MeteoSystem("Тестовая линия", 42, TestLine);

            XmlSerializer formatter = new XmlSerializer(typeof(MeteoSystem));

            using (FileStream fs = new FileStream("MeteoTest.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Test);
            }
            Console.WriteLine("DZ1-2 Var ");
        }
    }
}
