namespace Garage
{
    public class Ram : Vehicle, IGasVehicles  // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram goes Rumble rumble rumble!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Rams turns {direction} and runs into the Zero motorcycle!");
        }

        public override void Stop()
        {
            Console.WriteLine("The Ram suddenly stops then speeds away to avoid prison.  #SixBeerLunch");
        }


    }
}