namespace Shared.Puzzle.Interfaces
{
    public interface IPuzzleComponent
    {
        int PuzzleId { get; }
        bool Check();
    }
}