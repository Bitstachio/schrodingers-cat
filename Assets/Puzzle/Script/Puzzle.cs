namespace Puzzle.Script
{
    public class Puzzle
    {
        public string Question { get; }
        public string Answer { get; }

        public Puzzle(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }
    }
}