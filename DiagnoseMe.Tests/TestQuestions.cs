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

        [Test]
        public void GetAllQuestions()
        {
            Assert.DoesNotThrow(() => Doctor.GetAllQuestions(), @"Question parse error.");
        }

        [Test]
        public void AnswerOnQuestion()
        {
            var question = new Question();
            const bool answer = true;
            Human.AnswerOnQuestion(question, answer);
            Assert.That(question.IsAnsweredAsTrue, @"Human's answer was corrupted.");
        }

        [Test]
        public void ChooseAnswer()
        {
            Assert.That(Human.ChooseAnswer() == false, @"Default human's answer error.");
        }

        [Test]
        public void AnswerOnQuestions()
        {
            Assert.DoesNotThrow(() => Human.AnswerOnQuestions(Doctor.GetAllQuestions()), @"Human's answers parse error.");
        }

        [Test]
        public void GetAllDiseaseStrings()
        {
            Assert.DoesNotThrow(() => Doctor.GetAllDiseaseStrings(), @"File not found.");
        }
    }
}
