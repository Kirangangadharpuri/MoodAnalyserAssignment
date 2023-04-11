using MoodAnalyserAssignment;
namespace MoodAnalyserTest3
{
    [TestClass]
    public class UnitTest1
    {
        //TC 4.1 : Given MoodAnalyse class name should return MoodAnalyser object'

        [TestMethod]
       public void GivenMoodAnalyseClassName_ShouldeReturnMoodAnalyserObject()
       {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyzerApp.MoodAnalyse", "MoodAnalyse");
            //expected.Equals(obj);
            Assert.AreEqual(expected, obj);
       }

        //TC 4.2 : Given Improper class name should throw MoodAnaliserException.
        [TestMethod]
        public void GivenImproperClassNameShouldThrowMoodAnalyserException()
        {
            string excepted = "Class Not Found";
            try
            {
                object moodAnalyserObject = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyzerApp.DemoClass", "DemoClass");
            }
            catch(MoodAnalyserException exception)
            {
                Assert.AreEqual(excepted, exception.Message);
            }
        }

        //TC 4.3 : Given improper constructor should not throw MoodAnalyserException.
        [TestMethod]
        public void GivenImproperConstructorShouldThrowMoodAnalyserException()
        {
            string excepted = "Constructor is Not Found";
            try
            {
                object moodAnalyserObject = MoodAnalyzerFactory.CreateMoodAnalyse("DemoClass", "MoodAnalyse");
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(excepted, exception.Message);
            }
        }
    }
}