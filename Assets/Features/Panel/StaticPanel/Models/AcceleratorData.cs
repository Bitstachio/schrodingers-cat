using Features.Panel.StaticPanel.Interfaces;

namespace Features.Panel.StaticPanel.Models
{
    public class AcceleratorData : IPanelData
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