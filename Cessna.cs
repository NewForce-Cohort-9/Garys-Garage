namespace Garage
{
    public class Cessna : Vehicle, IGasVehicles  // Propellor light aircraft
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
            Console.WriteLine($" The {MainColor} goes Wah wah wah wah wah!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Cessna banks {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine("The bank robbers in the Cessna roll to a stop on the runway of a non-extradition country.");
        }



    }
}