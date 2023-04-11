using MoodAnalyserAssignment;
namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        //TC1.1
        [TestMethod]
        public void GivenSadMoodShouldReturnSad()
        {
            //arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";

            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            //act
            string mood = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }


        //TC1.2 &&&& TC2.1
        [TestMethod]
        public void GivenHappyMoodShouldReturnHappy()
        {
            //arrange
            string expected = "HAPPY";
            string message = "I am in Any Mood";

            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            //act
            string mood = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}