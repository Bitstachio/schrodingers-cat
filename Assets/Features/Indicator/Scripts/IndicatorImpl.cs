using Features.Indicator.Interfaces;
using UnityEngine;

namespace Features.Indicator.Scripts
{
    public class IndicatorImpl : MonoBehaviour, IIndicator
    {
        public void Show() => gameObject.SetActive(true);
        public void Hide() => gameObject.SetActive(false);
    }
}