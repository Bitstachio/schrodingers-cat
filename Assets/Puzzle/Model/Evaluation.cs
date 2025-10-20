namespace Puzzle.Model
{
    public class Evaluation
    {
        public bool Result { get; }
        public string Feedback { get; }

        public Evaluation(bool result, string feedback)
        {
            Result = result;
            Feedback = feedback;
        }
    }
}