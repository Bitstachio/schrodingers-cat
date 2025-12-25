using UnityEngine;
using UnityEngine.UI;

namespace Features.Panel.Scripts.Panels
{
    public class ToggleSwitch : MonoBehaviour
    {
        [SerializeField] private RectTransform handle;
        [SerializeField] private RectTransform onPosition;
        [SerializeField] private RectTransform offPosition;
        [SerializeField] private float moveSpeed = 12f;

        private Toggle _toggle;
        private Vector2 _targetPos;

        private void Awake()
        {
            _toggle = GetComponent<Toggle>();
            _toggle.onValueChanged.AddListener(OnToggleChanged);

            _targetPos = _toggle.isOn
                ? onPosition.anchoredPosition
                : offPosition.anchoredPosition;

            handle.anchoredPosition = _targetPos; // instant sync
        }

        private void Update()
        {
            handle.anchoredPosition = Vector2.Lerp(
                handle.anchoredPosition,
                _targetPos,
                Time.deltaTime * moveSpeed
            );
        }

        private void OnToggleChanged(bool isOn)
        {
            _targetPos = isOn
                ? onPosition.anchoredPosition
                : offPosition.anchoredPosition;
        }
    }
}