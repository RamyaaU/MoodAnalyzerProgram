using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProgram;

namespace UnitTestMood
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Givens the i am in sad mood should return sad.
        /// </summary>
        [TestMethod]
        public void Given_I_Am_In_Sad_Mood_Should_Return_SAD()
        {
            //Arrange
            string message = "I am in sad mood.";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(message);
            //Act
            string result = moodAnalyser.AnalyseMood(message);
            //Assert
            Assert.AreEqual("SAD", result);
        }

        /// <summary>
        /// Givens the i am in happy mood should return happy.
        /// </summary>
        [TestMethod]
        public void Given_I_Am_In_Happy_Mood_should_return_Happy()
        {
            //Arrange
            string message = "I am in Happy Mood";
            string expected = "HAPPY";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            //Act
            string result = moodAnalyzer.AnalyseMood(message);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
