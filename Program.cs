using System.Security;
using VehicleProgramII;

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Vehicle class
            Vehicle vehicle1 = new Vehicle();
            Vehicle vehicle2 = new Vehicle("Kanjula Gunathilaka", 50, "left");

            // Print field values of vehicle1
            Console.WriteLine("Vehicle 1:");
            Console.WriteLine($"ID: {vehicle1.Id}");
            Console.WriteLine($"Owner Name: {vehicle1.OwnerName}");
            Console.WriteLine($"Current Speed: {vehicle1.CurrentSpeed}");
            Console.WriteLine($"Current Direction: {vehicle1.CurrentDirection}");

            Console.WriteLine();

            // Print field values of vehicle2
            Console.WriteLine("Vehicle 2:");
            Console.WriteLine($"ID: {vehicle2.Id}");
            Console.WriteLine($"Owner Name: {vehicle2.OwnerName}");
            Console.WriteLine($"Current Speed: {vehicle2.CurrentSpeed}");
            Console.WriteLine($"Current Direction: {vehicle2.CurrentDirection}");

            Console.ReadKey();
        }
    }



