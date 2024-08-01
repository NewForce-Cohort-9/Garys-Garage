public interface IGasVehicles 
{
      double FuelCapacity { get; set; }

        void RefuelTank()
        {
            // method definition omitted
        }

        int CurrentTankPercentage {get; set;}
}