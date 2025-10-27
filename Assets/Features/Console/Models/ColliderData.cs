using Features.Console.Interfaces;

namespace Features.Console.Models
{
    public class ColliderData : IConsoleData
    {
        public float ImpactThreshold { get; set; }
        public float Elasticity { get; set; }

        public ColliderData(float impactThreshold = 0f, float elasticity = 0f)
        {
            ImpactThreshold = impactThreshold;
            Elasticity = elasticity;
        }
    }
}