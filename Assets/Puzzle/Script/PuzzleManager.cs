using UnityEngine;

namespace Puzzle.Script
{
    public class PuzzleManager : MonoBehaviour
    {
        [SerializeField] private PuzzlePanel panel;

        private static PuzzleManager Instance { get; set; }

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
        }

        private void Start() => HidePanel();

        public void ShowPanel(Puzzle puzzle) => panel.Show(puzzle);

        public void HidePanel() => panel.Hide();

        public void SubmitAnswer()
        {
            var answer = panel.GetAnswer();
            // TODO: Implement answer submission logic
        }
    }
}