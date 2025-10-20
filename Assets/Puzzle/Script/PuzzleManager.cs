using UnityEngine;

namespace Puzzle.Script
{
    public class PuzzleManager : MonoBehaviour
    {
        [SerializeField] private PuzzlePanel panel;

        public void Show(Puzzle puzzle)
        {
            panel.Show(puzzle);
        }

        public void Hide()
        {
            panel.Hide();
        }

        public void SubmitAnswer()
        {
            var answer = panel.GetAnswer();
            // TODO: Implement answer submission logic
        }
    }
}