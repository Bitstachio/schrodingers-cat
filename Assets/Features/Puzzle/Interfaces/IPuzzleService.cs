namespace Features.Puzzle.Interfaces
{
    public interface IPuzzleService
    {
        void Attempt(bool[] solution, bool[] key);
    }
}