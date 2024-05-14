using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleProgramII
{
    internal class Vehicle
    {
        // Fields
        private string ownerName;
        private double currentSpeed;
        private string currentDirection;
        private int id;

        // Static fields
        private static int vehicleId = 1;
        private const int maxSpeed = 100;

        // Properties
        public string OwnerName { get { return ownerName; } }
        public double CurrentSpeed { get { return currentSpeed; } }
        public string CurrentDirection { get { return currentDirection; } }
        public int Id { get { return id; } }

        // Constructors
        public Vehicle()
        {
            id = vehicleId++;
            currentSpeed = 0;
            currentDirection = "Forward";
            ownerName = "Unknown";
        }

        public Vehicle(string ownerName, double currentSpeed, string currentDirection) : this()
        {
            this.ownerName = ownerName;
            this.currentSpeed = currentSpeed;
            this.currentDirection = currentDirection;
        }

        // Methods
        public void ChangeSpeed(double newSpeed)
        {
            if (newSpeed >= 0 && newSpeed <= maxSpeed)
            {
                currentSpeed = newSpeed;
            }
            else
            {
                Console.WriteLine("Invalid speed value.");
            }
        }

        public void Stop()
        {
            currentSpeed = 0;
        }
    }
}
