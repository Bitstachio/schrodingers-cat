using System;
using Shared.EventBus.Implementation;
using Shared.EventBus.Structs;
using Shared.Puzzle.Interfaces;
using Shared.Puzzle.Utils;

namespace Shared.Puzzle.Services
{
    public class PuzzleService : EventPublisherService<PuzzleAttemptEventArgs>, IPuzzleService
    {
        public void Attempt(int id, bool[] solution, bool[] key) =>
            Publisher.Invoke(new PuzzleAttemptEventArgs(id, PuzzleUtils.CheckLockCombination(solution, key)));

        public void Attempt(int id, bool[] solution)
        {
            var key = new bool[solution.Length];
            Array.Fill(key, true);
            Attempt(id, solution, key);
        }
    }
}