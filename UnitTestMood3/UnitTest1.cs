using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProgram;

namespace UnitTestMood
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Given the i am in sad mood should return sad.
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
        /// Given the i am in happy mood should return happy.
        /// </summary>
        [TestMethod]
        public void Given_I_Am_In_Happy_Mood_Should_Return_HAPPY()
        {
            //Arrange
            string message = "I am in happy mood.";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(message);
            //Act
            string result = moodAnalyser.AnalyseMood(message);
            //Assert
            Assert.AreEqual("HAPPY", result);
        }
        //Removed TC2.1 Given_Null_Should_Return_HAPPY() because now null mood will throw custom exception


        /// <summary>
        /// Givens the null mood should return mood cannot be null.
        /// </summary>
        [TestMethod]
        public void GivenNullMood_ShouldReturnMoodCannotBeNull()
        { 
                //Arrange
                string message = null;
                MoodAnalyzer moodAnalyser = new MoodAnalyzer(message);
                //Act
                string result = moodAnalyser.AnalyseMood(message);
                //Assert
                Assert.AreEqual("Mood cannot be null", result);
        }

        /// <summary>
        /// Givens the empty mood should throw mood cannot be empty.
        /// </summary>
        [TestMethod]
        public void GivenEmptyMood_ShouldThrowMoodCannotBeEmpty()
        {
                //Arrange
                string message = "";
                MoodAnalyzer moodAnalyser = new MoodAnalyzer(message);
                //Act
                string result = moodAnalyser.AnalyseMood(message);
                //Assert
                Assert.AreEqual("Mood should not be empty",message);
        }
        /// <summary>
        /// Given the null mood should throw mood analysis exception indicating null mood.
        /// </summary>
        [TestMethod]
        public void Given_Null_Mood_Should_Throw_MoodAnalysisException_Indicating_Null_Mood()
        {
            try
            {
                //Arrange
                string message = null;
                MoodAnalyzer moodAnalyser = new MoodAnalyzer(message);
                //Act
                string result = moodAnalyser.AnalyseMood(message);
            }
            catch (CustomException e)
            {
                //Assert
                Assert.AreEqual("Mood should not be null.", e.Message);
            }
        }

        /// <summary>
        /// Given the empty mood should throw mood analysis exception indicating empty mood.
        /// </summary>
        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_Empty_Mood()
        {
            try
            {
                //Arrange
                string message = "";
                MoodAnalyzer moodAnalyser = new MoodAnalyzer(message);
                //Act
                string result = moodAnalyser.AnalyseMood(message);
            }
            catch (CustomException e)
            {
                //Assert
                Assert.AreEqual("Mood should not be empty.", e.Message);
            }
        }
    }
}