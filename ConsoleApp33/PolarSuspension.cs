namespace ConsoleApp33
{
    internal class PolarSuspension : SatelliteDish
    {
        public PolarSuspension(double diameter, string material, double price) : base(diameter, material, price)
        {

        }
        public override double GetQuality()
        {
            return 2 * base.GetQuality();
        }
    }
}
