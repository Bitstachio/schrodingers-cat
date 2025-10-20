using Puzzle.Model;
using TMPro;
using UnityEngine;

namespace Puzzle.Script
{
    public class EvaluationPanel : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI feedback;

        private void Start() => Hide();

        public void Show(Evaluation evaluation)
        {
            feedback.text = evaluation.Feedback;
            gameObject.SetActive(true);
        }

        public void Hide() => gameObject.SetActive(false);
    }
}