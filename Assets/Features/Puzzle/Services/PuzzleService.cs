using Features.Puzzle.Interfaces;
using Features.Puzzle.Utils;
using Shared.EventBus.Interfaces;
using Shared.EventBus.Structs;
using VContainer;

namespace Features.Puzzle.Services
{
    public class PuzzleService : IPuzzleService
    {
        private IEventPublisher<PuzzleAttemptEventArgs> _publisher;

        [Inject]
        public void Construct(IEventPublisher<PuzzleAttemptEventArgs> publisher) => _publisher = publisher;

        public void Attempt(bool[] solution, bool[] key) =>
            _publisher.Invoke(new PuzzleAttemptEventArgs(PuzzleUtils.CheckLockCombination(solution, key)));
    }
}