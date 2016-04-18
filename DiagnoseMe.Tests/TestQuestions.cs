using System.Linq;
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

        [Test]
        public void GetAllParsedQuestions()
        {
            Assert.DoesNotThrow(() => Doctor.GetAllQuestionStrings().Select(Question.Parse), @"Question parse error.");
        }
    }
}
