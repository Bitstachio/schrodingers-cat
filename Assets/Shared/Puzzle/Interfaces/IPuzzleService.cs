namespace Shared.Puzzle.Interfaces
{
    public interface IPuzzleService
    {
        void Attempt(int id, bool[] solution, bool[] key);
    }
}