namespace ConsoleApp33
{
    internal class SatelliteDish
    {
        public double diameter { get; set; }
        public string material { get; set; }
        public double price { get; set; }

        public SatelliteDish(double diameter, string material, double price)
        {
            this.diameter = diameter;
            this.material = material;
            this.price = price;
        }

        public virtual double GetQuality()
        {
            return diameter / price; 
        }
    }
}
