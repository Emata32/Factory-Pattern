namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels dose your Vehicle have ?");
            var  wheels = int.Parse(Console.ReadLine());
            var  vehicle = VehicleFactory.GetVehicle(wheels);
            vehicle.Drive();
        }
    }
}
