using UnityEngine;

namespace Shared.ScriptableObjects.Panel.Banner
{
    [CreateAssetMenu(fileName = "Banner Content", menuName = "Panel Content/Banner Content", order = 0)]
    public class BannerContent : ScriptableObject
    {
        [SerializeField] private string text;

        public string Text => text;
    }
}