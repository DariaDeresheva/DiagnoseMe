using System;
using System.Collections.Generic;
using System.Linq;

namespace DiagnoseMe
{
    public class Human
    {
        public static Question AnswerOnQuestion(Question question, bool answer)
        {
            question.IsAnsweredAsTrue = answer;
            return question;
        }

        public static bool ChooseAnswer()
        {
            var stringAnswer = Console.ReadLine();
            return stringAnswer != null && bool.Parse(stringAnswer);
        }

        public static IEnumerable<Question> AnswerOnQuestions(IEnumerable<Question> questions)
        {
            return questions.Select(question => AnswerOnQuestion(question, ChooseAnswer()));
        }
    }
}
