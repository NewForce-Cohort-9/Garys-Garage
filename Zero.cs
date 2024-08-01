namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;

            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero goes NNNNYYYYEEEWWW!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Zero turns {direction}!");
        }

        public override void Stop()
        {
            Console.WriteLine("The Zero drags to a stop after sliding on the pavement!");
        }



    }
}