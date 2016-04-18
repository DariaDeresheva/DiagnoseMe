using NUnit.Framework;

namespace DiagnoseMe.Tests
{
    [TestFixture]
    internal class TestQuestions
    {
        [Test]
        public void GetAllQuestionStrings()
        {
            Assert.DoesNotThrow(() => Doctor.GetAllQuestionStrings(), @"File not found.");
        }
    }
}
