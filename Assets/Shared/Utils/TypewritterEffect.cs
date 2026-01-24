using System;
using System.Collections;
using TMPro;
using UnityEngine;

namespace Shared.Utils
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class TypewriterEffect : MonoBehaviour
    {
        private TextMeshProUGUI _textComponent;
        private Coroutine _typingCoroutine;
        private string _currentFullText;

        public bool IsTyping => _typingCoroutine != null;

        private void Awake()
        {
            _textComponent = GetComponent<TextMeshProUGUI>();
        }

        public void Play(string content, float delay, Action onComplete = null)
        {
            Stop();
            _currentFullText = content;
            _typingCoroutine = StartCoroutine(TypeRoutine(content, delay, onComplete));
        }

        public void Skip()
        {
            if (!IsTyping) return;

            Stop();
            _textComponent.maxVisibleCharacters = _currentFullText.Length;
        }

        public void Stop()
        {
            if (_typingCoroutine != null)
            {
                StopCoroutine(_typingCoroutine);
                _typingCoroutine = null;
            }
        }

        private IEnumerator TypeRoutine(string content, float delay, Action onComplete)
        {
            _textComponent.text = content;
            _textComponent.maxVisibleCharacters = 0;

            for (int i = 0; i <= content.Length; i++)
            {
                _textComponent.maxVisibleCharacters = i;
                yield return new WaitForSeconds(delay);
            }

            _typingCoroutine = null;
            onComplete?.Invoke();
        }
    }
}