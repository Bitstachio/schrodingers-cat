using System.Linq;
using Shared.Puzzle.Exceptions;

namespace Shared.Puzzle.Utils
{
    public static class PuzzleUtils
    {
        public static bool CheckLockCombination(bool[] toggles, bool[] key)
        {
            if (toggles.Length != key.Length) throw new ToggleLengthMismatchException(toggles.Length, key.Length);
            return !toggles.Where((t, i) => t != key[i]).Any();
        }
    }
}