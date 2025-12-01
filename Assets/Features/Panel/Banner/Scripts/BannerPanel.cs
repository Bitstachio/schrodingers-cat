using Features.Panel.Common.Exceptions;
using UnityEngine;

namespace Features.Panel.Banner.Scripts
{
    public class BannerPanel : MonoBehaviour
    {
        public void Show(BannerContent banner)
        {
            if (gameObject.activeSelf) throw new PanelAlreadyOpenException();
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            if (!gameObject.activeSelf) throw new PanelNotOpenException();
            gameObject.SetActive(false);
        }
    }
}