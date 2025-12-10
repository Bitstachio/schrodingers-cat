using Features.Panel.Common.Exceptions;
using Features.Panel.Common.Interfaces;
using TMPro;
using UnityEngine;

namespace Features.Panel.Banner.Scripts
{
    public class BannerPanel : MonoBehaviour, IPanel<BannerContent>
    {
        [SerializeField] private TextMeshProUGUI textComponent;

        //===== Interface Implementation =====

        public void Show(BannerContent banner)
        {
            if (gameObject.activeSelf) throw new PanelAlreadyOpenException();
            textComponent.text = banner.Text;
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            if (!gameObject.activeSelf) throw new PanelNotOpenException();
            textComponent.text = string.Empty;
            gameObject.SetActive(false);
        }
    }
}