namespace ConsoleApp33
{
    internal class ToroidalSuspension : SatelliteDish
    {
        public ToroidalSuspension(double diameter, string material, double price) : base(diameter, material, price)
        {

        }
        public override double GetQuality()
        {
            return 2.5 * base.GetQuality();
        }
    }
}
