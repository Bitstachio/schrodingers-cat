using Features.Puzzle.Interfaces;
using Features.Puzzle.Utils;
using Shared.EventBus.Implementation;
using Shared.EventBus.Structs;

namespace Features.Puzzle.Services
{
    public class PuzzleService : EventPublisherService<PuzzleAttemptEventArgs>, IPuzzleService
    {
        public void Attempt(int id, bool[] solution, bool[] key) =>
            Publisher.Invoke(new PuzzleAttemptEventArgs(id, PuzzleUtils.CheckLockCombination(solution, key)));
    }
}