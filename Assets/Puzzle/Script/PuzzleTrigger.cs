using Puzzle.Interface;
using UnityEngine;

namespace Puzzle.Script
{
    public class PuzzleTrigger : MonoBehaviour
    {
        [SerializeField] private PuzzleManager puzzleManager;
        [SerializeField] private string question;
        [SerializeField] private GameObject evaluatorObj;
        [SerializeField] private GameObject indicator;
        
        private bool _playerInRange;
        
        private void Start() => indicator.SetActive(false);

        private void Update()
        {
            indicator.SetActive(_playerInRange);
            if (!_playerInRange || !Input.GetKeyDown(KeyCode.E)) return;
            // TODO: Fix this messy casting
            var evaluator = evaluatorObj.GetComponent<MonoBehaviour>() as IEvaluator;
            puzzleManager.Show(new Puzzle(question, evaluator));
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