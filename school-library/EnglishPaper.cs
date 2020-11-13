using System;
namespace school_library
{
    public class EnglishPaper : IScored
    {
        public string Title { get; set; }
        public string MinimumWordCount { get; set; }
        public string PaperText { get; set; }
        public float Score { get; set; }
        public float MaximumScore { get; set; }

        public EnglishPaper()
        {
        }
    }
}
