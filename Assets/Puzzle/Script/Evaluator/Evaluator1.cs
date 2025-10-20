using Puzzle.Interface;
using Puzzle.Model;
using UnityEngine;

namespace Puzzle.Script.Evaluator
{
    public class Evaluator1 : MonoBehaviour, IEvaluator
    {
        public Evaluation Evaluate(string response)
        {
            var responseDouble = response.Length == 0 ? 0 : double.Parse(response);
            const double answer = 20070d;
            const double innerTolerance = 0.1;
            const double outerTolerance = 0.3;

            return responseDouble switch
            {
                >= answer * (1 - innerTolerance) and <= answer * (1 + innerTolerance) => new Evaluation(true, "Success"),
                > answer * (1 + innerTolerance) and <= answer * (1 + outerTolerance) => new Evaluation(false,
                    "During proton acceleration testing, the input energy was slightly higher than required. While the target of 99.9% of the speed of light was reached, the excess energy caused minor overheating damage."),
                > answer * (1 + outerTolerance) => new Evaluation(false,
                    "During proton acceleration testing, the input energy was significantly higher than required. Although the target of 99.9% of the speed of light was reached, the excessive energy resulted in major overheating damage."),
                _ => new Evaluation(false,
                    "During proton acceleration testing, the target of 99.9% of the speed of light was not reached due to insufficient energy input. The accelerator should be modified to increase the energy input.")
            };
        }
    }
}