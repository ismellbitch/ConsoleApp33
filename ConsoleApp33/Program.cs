using ConsoleApp33;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите тип антенны: ");
            string antennaType = Console.ReadLine();    
            Console.Write("Введите диаметр: ");
            double diameter = double.Parse(Console.ReadLine());
            Console.Write("Введите материал: ");
            string material = Console.ReadLine();
            Console.Write("Введите цену: ");
            double price = double.Parse(Console.ReadLine());

            if (antennaType == "азимутальная" || antennaType == "Азимутальная") 
            { SatelliteDish antenna = new AzimuthalSuspension(diameter, material, price); 
                Console.WriteLine(antenna.GetQuality()); }
            else if (antennaType == "полярная" || antennaType == "Полярная")
            {
                SatelliteDish antenna = new PolarSuspension(diameter, material, price);
                Console.WriteLine(antenna.GetQuality());
            }
            else if (antennaType == "тороидальная" || antennaType == "Тороидальная")
            {
                SatelliteDish antenna = new ToroidalSuspension(diameter, material, price);
                Console.WriteLine(antenna.GetQuality());
            }
            else 
            { SatelliteDish antenna = new SatelliteDish(diameter, material, price); 
                Console.WriteLine(antenna.GetQuality()); }
        }
    }
}