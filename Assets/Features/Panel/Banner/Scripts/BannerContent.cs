using UnityEngine;

namespace Features.Panel.Banner.Scripts
{
    [CreateAssetMenu(fileName = "Banner Content", menuName = "Panel Content/Banner Content", order = 0)]
    public class BannerContent : ScriptableObject
    {
        [SerializeField] private string text;

        public string Text => text;
    }
}