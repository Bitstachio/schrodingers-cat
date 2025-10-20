using Puzzle.Model;

namespace Puzzle.Interface
{
    public interface IEvaluator
    {
        Evaluation Evaluate(string response);
    }
}