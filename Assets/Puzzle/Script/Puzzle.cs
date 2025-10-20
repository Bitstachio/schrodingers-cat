using Puzzle.Interface;

namespace Puzzle.Script
{
    public class Puzzle
    {
        public int Id { get; }
        public string Question { get; }
        public IEvaluator Evaluator { get; }

        public Puzzle(int id, string question, IEvaluator evaluator)
        {
            Id = id;
            Question = question;
            Evaluator = evaluator;
        }
    }
}