using System.Collections;
using Features.Panel.Exceptions;
using Features.Panel.Interfaces;
using Shared.ScriptableObjects.Panel.Dialogue;
using TMPro;
using UnityEngine;

namespace Features.Panel.Scripts.Panels
{
    public class DialoguePanel : MonoBehaviour, IPanel<DialogueContent>
    {
        [SerializeField] private TextMeshProUGUI speakerTextComponent;
        [SerializeField] private TextMeshProUGUI contentTextComponent;
        [SerializeField] private float typingDelay;

        private string[] _lines;
        private int _lineIndex;

        //===== Lifecycle =====

        private void Update()
        {
            // TODO: Update control system
            if (!Input.GetMouseButtonDown(0)) return;

            // If the current line is already fully displayed, advance to the next one
            if (contentTextComponent.text == _lines[_lineIndex]) NextLine();
            // Skip the typing animation and instantly show the full line
            else
            {
                StopAllCoroutines();
                contentTextComponent.text = _lines[_lineIndex];
            }
        }

        //===== Interface Implementation =====

        public void Show(DialogueContent dialogue)
        {
            if (gameObject.activeSelf) throw new PanelAlreadyOpenException();
            gameObject.SetActive(true);

            // The inspector may contain placeholder text for visualization purposes, which should be cleared
            contentTextComponent.text = string.Empty;
            speakerTextComponent.text = dialogue.Speaker;
            _lines = dialogue.Lines;
            _lineIndex = 0;

            StartCoroutine(TypeLine());
        }

        public void Hide()
        {
            if (!gameObject.activeSelf) throw new PanelNotOpenException();
            gameObject.SetActive(false);

            StopAllCoroutines();
            contentTextComponent.text = string.Empty;
            _lineIndex = 0;
        }

        //===== Utility =====

        private IEnumerator TypeLine()
        {
            foreach (var character in _lines[_lineIndex].ToCharArray())
            {
                contentTextComponent.text += character;
                yield return new WaitForSeconds(typingDelay);
            }
        }

        private void NextLine()
        {
            if (_lineIndex < _lines.Length - 1)
            {
                _lineIndex++;
                contentTextComponent.text = string.Empty;
                StartCoroutine(TypeLine());
            }
            else Hide();
        }
    }
}