

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
            string Actualresult = mood.Mood(sadmood);
            string expected = "Sad";
            Assert.AreEqual(expected, Actualresult);

        }
    }
}