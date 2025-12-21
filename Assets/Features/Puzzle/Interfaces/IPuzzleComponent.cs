namespace Features.Puzzle.Interfaces
{
    public interface IPuzzleComponent
    {
        int PuzzleId { get; }
        bool Evaluate();
    }
}