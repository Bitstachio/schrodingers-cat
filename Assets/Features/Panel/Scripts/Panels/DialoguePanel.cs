using System.Collections;
using TMPro;
using UnityEngine;

namespace Features.Panel.Scripts.Panels
{
    public class DialoguePanel : BasePanel
    {
        [SerializeField] private TextMeshProUGUI textComponent;
        [SerializeField] private string[] lines;
        [SerializeField] private float typingDelay;

        private int _lineIndex;

        //===== Lifecycle =====

        private void Start()
        {
            textComponent.text = string.Empty;
            StartDialogue();
        }

        private void Update()
        {
            // TODO: Update control system
            if (!Input.GetMouseButtonDown(0)) return;

            // If the current line is already fully displayed, advance to the next one
            if (textComponent.text == lines[_lineIndex]) NextLine();
            // Skip the typing animation and instantly show the full line
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[_lineIndex];
            }
        }

        //===== Utility =====

        private void StartDialogue()
        {
            _lineIndex = 0;
            StartCoroutine(TypeLine());
        }

        private IEnumerator TypeLine()
        {
            foreach (var character in lines[_lineIndex].ToCharArray())
            {
                textComponent.text += character;
                yield return new WaitForSeconds(typingDelay);
            }
        }

        private void NextLine()
        {
            if (_lineIndex < lines.Length - 1)
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