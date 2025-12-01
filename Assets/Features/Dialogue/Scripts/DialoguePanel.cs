using System.Collections;
using Features.Panel.Scripts.Panels;
using TMPro;
using UnityEngine;

namespace Features.Dialogue.Scripts
{
    public class DialoguePanel : BasePanel
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

        //===== Utility =====

        public void StartDialogue(DialogueContent dialogue)
        {
            _speaker = dialogue.Speaker;
            _lines = dialogue.Lines;
            _lineIndex = 0;
            
            gameObject.SetActive(true);
            StartCoroutine(TypeLine());
        }

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