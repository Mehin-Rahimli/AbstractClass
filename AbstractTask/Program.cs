namespace AbstractTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car
            {
                FactoryName = "Ford",
                Model = "Bus",
                Color = "Green",
                DriveTime = 100,
                DrivePath = 2000,
                DoorCount = 3,
                IsElectricCar = true
            };

            Bicycle bicycle = new Bicycle
            {
                FactoryName = "cycle",
                Model = "28size",
                Color = "Grey",
                DriveTime = 250,
                DrivePath = 2000,
                Type="City"
            };


            Console.WriteLine(car.GetInfo());
            Console.WriteLine(bicycle.GetInfo());
            Console.WriteLine(car.DefineNatureHarmness());
            Console.WriteLine(bicycle.DefineNatureHarmness());
            Vehicle[] vehicle = { bicycle, car };
            foreach (Vehicle item in vehicle)
            {

                Console.WriteLine(item);
            }

        }
    }
}
