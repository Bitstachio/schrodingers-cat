using Features.Common.Interactable.Interfaces;
using UnityEngine;

namespace Features.Common.Interactable.Scripts
{
    public class Indicator : MonoBehaviour, IIndicator
    {
        public void Show() => gameObject.SetActive(true);
        public void Hide() => gameObject.SetActive(false);
    }
}