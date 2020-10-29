using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProgram
{
    
    public class MoodAnalyzer
    {
        
        private string message;
        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyzer"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Analyses the mood.
        /// </summary>
        /// <param name="mesaage">The mesaage.</param>
        /// <returns></returns>
        public string AnalyseMood(string mesaage)
        {
            if (this.message.Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
