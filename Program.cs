// Your challenge is to replace your Main method with the following code and make the appropriate changes and additions to your project in order to make this Main method work.

// HINT: An example addition to your code might be an IElectricVehicle interface.

namespace Garage
{
    class Program
    {
        static void Main (string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new();
            Cessna mx410 = new Cessna();
            Ram fifteenHundred = new();


            fxs.BatteryKWh = 17.5;
            fxs.MainColor = "Green";
            fxs.MaximumOccupancy = 2;

            modelS.BatteryKWh = 99.5;
            modelS.MainColor = "Red";
            modelS.MaximumOccupancy = 5;

            mx410.FuelCapacity = 35;
            mx410.MainColor = "White";
            mx410.MaximumOccupancy = 6;

            fifteenHundred.FuelCapacity = 20;
            fifteenHundred.MainColor = "Black";
            fifteenHundred.MaximumOccupancy = 12;

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            fifteenHundred.Drive();

            fxs.Turn("right");
            modelS.Turn("left");
            mx410.Turn("left");
            fifteenHundred.Turn("right");

            fxs.Stop();
            modelS.Stop();
            mx410.Stop();
            fifteenHundred.Stop();


            // Zero fxs = new Zero();
            Zero fx = new Zero();
            // Tesla modelS = new Tesla();

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage} first");
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage} second");
            }

            /***********************************************/

            Ram ram = new Ram ();
            Cessna cessna150 = new Cessna ();

            List<IGasVehicles> gasVehicles = new List<IGasVehicles>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGasVehicles gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach(IGasVehicles gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IGasVehicles gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}