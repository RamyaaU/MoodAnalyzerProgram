using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProgram
{
    public class CustomException : Exception
    {
        
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
        }

        private readonly ExceptionType type;
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomException"/> class.
        /// </summary>
        /// <param name="Type">The type.</param>
        /// <param name="message">The message.</param>
        public CustomException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
