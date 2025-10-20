using TMPro;
using UnityEngine;

namespace Puzzle.Script
{
    public class PuzzlePanel : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI questionText;
        [SerializeField] private TMP_InputField answerInput;

        private Puzzle _puzzle;

        public void Show(Puzzle puzzle)
        {
            _puzzle = puzzle;
            gameObject.SetActive(true);
            questionText.text = _puzzle.Question;
            answerInput.text = "";
        }

        public string GetAnswer() => answerInput.text;

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public void Submit()
        {
            var evaluation = _puzzle.Evaluator.Evaluate(answerInput.text);
            Debug.Log(evaluation.Result);
            Debug.Log(evaluation.Feedback);
        }
    }
}