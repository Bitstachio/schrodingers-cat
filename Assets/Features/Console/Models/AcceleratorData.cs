using Features.Console.Interfaces;

namespace Features.Console.Models
{
    public class AcceleratorData : IConsoleData
    {
        public float AccelerationForce { get; set; }
        public float EnergyConsumption { get; set; }

        public AcceleratorData(float accelerationForce = 0f, float energyConsumption = 0f)
        {
            AccelerationForce = accelerationForce;
            EnergyConsumption = energyConsumption;
        }
    }
}