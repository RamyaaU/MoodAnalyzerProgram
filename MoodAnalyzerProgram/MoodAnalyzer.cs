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
            try
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
            catch
            {
                return "HAPPY";
            }
        }
        /// <summary>
        /// Analyses the mood live.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="CustomException">
        /// mood should not be empty
        /// or
        /// mood should not be null
        /// </exception>
        public string AnalyseMoodLive()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "mood should not be empty");
                }
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "mood should not be null");
            }
        }
    }
}
