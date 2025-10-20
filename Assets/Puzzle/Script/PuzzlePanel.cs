using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Puzzle.Script
{
    public class PuzzlePanel : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI questionText;
        [SerializeField] private TMP_InputField answerInput;
        [SerializeField] private EvaluationPanel evaluationPanel;

        public UnityEvent<int> onPlayerSucceed;

        private Puzzle _puzzle;

        public void Show(Puzzle puzzle)
        {
            _puzzle = puzzle;
            questionText.text = _puzzle.Question;
            answerInput.text = "";
            gameObject.SetActive(true);
        }

        public string GetAnswer() => answerInput.text;

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public void Submit()
        {
            var evaluation = _puzzle.Evaluator.Evaluate(answerInput.text);
            evaluationPanel.Show(evaluation);
            if (evaluation.Result) onPlayerSucceed.Invoke(_puzzle.Id);
            Hide();
        }
    }
}