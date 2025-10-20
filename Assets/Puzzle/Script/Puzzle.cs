using Puzzle.Interface;

namespace Puzzle.Script
{
    public class Puzzle
    {
        public string Question { get; }
        public IEvaluator Evaluator { get; }

        public Puzzle(string question, IEvaluator evaluator)
        {
            Question = question;
            Evaluator = evaluator;
        }
    }
}