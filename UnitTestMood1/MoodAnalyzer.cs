using System;

namespace UnitTestMood
{
    internal class MoodAnalyzer
    {
        private string message;

        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        internal string AnalyseMood(string message)
        {
            throw new NotImplementedException();
        }

        internal string AnalyseMood()
        {
            throw new NotImplementedException();
        }
    }
}