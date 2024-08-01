namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle // Electric car
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla goes Brrrrrr!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Tesla turns {direction} into oncoming traffic.  #AutoPilot");
        }

        public override void Stop()
        {
            Console.WriteLine("The Tesla stops after driving over a wrecked Zero motorcycle.");
        }



    }
}