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
            gameObject.SetActive(true);
            
            textComponent.text = banner.Text;
        }

        public void Hide()
        {
            if (!gameObject.activeSelf) throw new PanelNotOpenException();
            gameObject.SetActive(false);
            
            textComponent.text = string.Empty;
        }
    }
}