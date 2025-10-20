using Puzzle.Interface;
using UnityEngine;

namespace Puzzle.Script
{
    public class PuzzleTrigger : MonoBehaviour
    {
        [SerializeField] private PuzzleManager puzzleManager;
        [SerializeField] private string question;
        [SerializeField] private GameObject evaluatorObj;
        [SerializeField] private GameObject proximityIndicator;
        [SerializeField] private GameObject completionIndicator;

        // TODO: Place event in the puzzle manager
        [SerializeField] private PuzzlePanel puzzlePanel;

        private bool _playerInRange;
        private bool _completed;

        private void OnEnable()
        {
            puzzlePanel.onPlayerSucceed.AddListener(HandlePlayerSuccess);
        }

        private void OnDisable()
        {
            puzzlePanel.onPlayerSucceed.RemoveListener(HandlePlayerSuccess);
        }

        private void HandlePlayerSuccess() => _completed = true;

        private void Start() {
            proximityIndicator.SetActive(false);
            completionIndicator.SetActive(false);
        }

        private void Update()
        {
            proximityIndicator.SetActive(!_completed && _playerInRange);
            completionIndicator.SetActive(_completed);
            
            if (_completed || !_playerInRange || !Input.GetKeyDown(KeyCode.E)) return;
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