using System;
namespace school_library
{
    public class ScoreUtility
    {
        public static IScored BestOfTwo(IScored Assignment1, IScored Assignment2)
        {
            var score1 = Assignment1.Score / Assignment2.MaximumScore;
            var score2 = Assignment2.Score / Assignment2.MaximumScore;

        }
        public ScoreUtility()
        {
        }
    }
}
