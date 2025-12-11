using System.Collections;
using Features.Panel.Common.Exceptions;
using Features.Panel.Common.Interfaces;
using TMPro;
using UnityEngine;

namespace Features.Panel.Dialogue.Scripts
{
    public class DialoguePanel : MonoBehaviour, IPanel<DialogueContent>
    {
        [SerializeField] private TextMeshProUGUI textComponent;
        [SerializeField] private float typingDelay;

        private string _speaker;
        private string[] _lines;
        private int _lineIndex;

        //===== Lifecycle =====

        private void Update()
        {
            // TODO: Update control system
            if (!Input.GetMouseButtonDown(0)) return;

            // If the current line is already fully displayed, advance to the next one
            if (textComponent.text == _lines[_lineIndex]) NextLine();
            // Skip the typing animation and instantly show the full line
            else
            {
                StopAllCoroutines();
                textComponent.text = _lines[_lineIndex];
            }
        }

        //===== Interafce Implementation =====

        public void Show(DialogueContent dialogue)
        {
            if (gameObject.activeSelf) throw new PanelAlreadyOpenException();
            gameObject.SetActive(true);
            
            _speaker = dialogue.Speaker;
            _lines = dialogue.Lines;
            _lineIndex = 0;

            StartCoroutine(TypeLine());
        }

        public void Hide()
        {
            if (!gameObject.activeSelf) throw new PanelNotOpenException();
            gameObject.SetActive(false);
            
            StopAllCoroutines();
            textComponent.text = string.Empty;
            _lineIndex = 0;
        }

        //===== Utility =====

        private IEnumerator TypeLine()
        {
            foreach (var character in _lines[_lineIndex].ToCharArray())
            {
                textComponent.text += character;
                yield return new WaitForSeconds(typingDelay);
            }
        }

        private void NextLine()
        {
            if (_lineIndex < _lines.Length - 1)
            {
                _lineIndex++;
                textComponent.text = string.Empty;
                StartCoroutine(TypeLine());
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
}