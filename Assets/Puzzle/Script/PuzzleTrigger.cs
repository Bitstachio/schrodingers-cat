using UnityEngine;

namespace Puzzle.Script
{
    public class PuzzleTrigger : MonoBehaviour
    {
        [SerializeField] private PuzzleManager puzzleManager;
        [SerializeField] private string question;
        [SerializeField] private string answer;
        
        private bool _playerInRange;

        private void Update()
        {
            if (_playerInRange && Input.GetKeyDown(KeyCode.E))
            {
                puzzleManager.Show(new Puzzle(question, answer));
            }
        }
         
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player")) _playerInRange = true;
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Player")) _playerInRange = false;
        }
    }
}