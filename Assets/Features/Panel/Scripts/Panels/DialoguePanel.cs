using Features.Panel.Exceptions;
using Features.Panel.Interfaces;
using Shared.ScriptableObjects.Panel.Dialogue;
using Shared.Utils;
using TMPro;
using UnityEngine;

namespace Features.Panel.Scripts.Panels
{
    public class DialoguePanel : MonoBehaviour, IPanel<DialogueContent>
    {
        [SerializeField] private TextMeshProUGUI speakerTextComponent;
        [SerializeField] private TextMeshProUGUI contentTextComponent;
        [SerializeField] private float typingDelay;

        private TypewriterEffect _typewriter;
        private string[] _lines;
        private int _lineIndex;

        private void Awake()
        {
            _typewriter = contentTextComponent.GetComponent<TypewriterEffect>();
        }

        private void Update()
        {
            // TODO: Update control system
            if (!Input.GetMouseButtonDown(0)) return;

            // Use the typewriter if it exists, otherwise fallback to standard text logic
            if (_typewriter && _typewriter.IsTyping) _typewriter.Skip();
            else NextLine();
        }

        public void Show(DialogueContent dialogue)
        {
            if (gameObject.activeSelf) throw new PanelAlreadyOpenException();
            gameObject.SetActive(true);

            speakerTextComponent.text = dialogue.Speaker;
            _lines = dialogue.Lines;
            _lineIndex = 0;

            DisplayCurrentLine();
        }

        private void DisplayCurrentLine()
        {
            var line = _lines[_lineIndex];

            if (_typewriter) _typewriter.Play(line, typingDelay);
            else contentTextComponent.text = line;
        }

        private void NextLine()
        {
            if (_lineIndex < _lines.Length - 1)
            {
                _lineIndex++;
                DisplayCurrentLine();
            }
            else Hide();
        }

        public void Hide()
        {
            if (!gameObject.activeSelf) throw new PanelNotOpenException();
            if (_typewriter) _typewriter.Stop();

            gameObject.SetActive(false);
            _lineIndex = 0;
        }
    }
}