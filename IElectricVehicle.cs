public interface IElectricVehicle 
{
    void ChargeBattery()
    {
        
    }
    double BatteryKWh { get; set; }

    int CurrentChargePercentage {get; set;}

}