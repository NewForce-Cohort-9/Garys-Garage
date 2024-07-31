namespace Garage
{
    class Program
    {
        static void Main(string[] args)
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

        }
    }
}