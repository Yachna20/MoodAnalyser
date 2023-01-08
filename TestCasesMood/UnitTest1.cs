

using MoodAnalyser;

namespace TestCasesMood
    
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodShouldReturnSadMood()
        {
            const string happymood = "Happy";
            const string sadmood = "Sad";
            AnalyseMood mood = new AnalyseMood();
            string Actualresult = mood.Mood(happymood);
            string expected = "Happy";
            Assert.AreEqual(expected, Actualresult);

        }
    }
}