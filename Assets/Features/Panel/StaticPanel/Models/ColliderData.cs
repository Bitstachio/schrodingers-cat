using Features.Panel.StaticPanel.Interfaces;

namespace Features.Panel.StaticPanel.Models
{
    public class ColliderData : IPanelData
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