using MoodAnalyserAssignment;
namespace MoodAnalyserTest3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //TC 3.1: Given null mood should throw moodanalysisException.
        public void Given_NULL_Mood_Should_Throw_MoodAnalyserException()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyseMood();
            }
            catch(MoodAnalyserException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }

        [TestMethod]
        //TC 3.2: Given Empty mood should throw moodanalysisException Indicating Empty mood.
        public void Given_EMPTY_Mood_Should_Throw_MoodAnalyserException_IndicatingEmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }

    }
}