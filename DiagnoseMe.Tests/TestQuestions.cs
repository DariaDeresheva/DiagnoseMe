using System.Collections.Generic;
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
            var question = new Question();
            Assert.That(Human.ChooseAnswer(question) == false, @"Default human's answer error.");
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

        [Test]
        public void GetAllParsedDiseases()
        {
            Assert.DoesNotThrow(() => Doctor.GetAllDiseaseStrings().Select(Disease.Parse), @"Disease parse error.");
        }

        [Test]
        public void GetAllDiseases()
        {
            Assert.DoesNotThrow(() => Doctor.GetAllDiseases(), @"Disease parse error.");
        }

        [Test]
        public void FindDisease()
        {
            var questions = new List<Question>
            {
                new Question {Number = 1, Text = @"Question 1"},
                new Question {Number = 2, Text = @"Question 2"}
            };

            var diseases = new List<Disease>
            {
                new Disease {Name = @"Disease 1", NumbersOfSymptoms = new List<int> {questions.First().Number}},
                new Disease {Name = @"Disease 2", NumbersOfSymptoms = new List<int> {questions.Last().Number}}
            };

            var answeredQuestions = new List<Question>
            {
                Human.AnswerOnQuestion(questions.First(), true),
                Human.AnswerOnQuestion(questions.Last(), false)
            };

            var diseaseFound = Doctor.FindDisease(answeredQuestions, diseases);

            Assert.That(diseaseFound.Name == @"Disease 1", @"Analyze answers error.");
        }
    }
}
