using System;
using System.Collections.Generic;

namespace DiagnoseMe
{
    public class Human
    {
        public static void AnswerOnQuestion(Question question, bool answer)
        {
            question.IsAnsweredAsTrue = answer;
        }

        public static bool ChooseAnswer()
        {
            var stringAnswer = Console.ReadLine();
            return stringAnswer != null && bool.Parse(stringAnswer);
        }

        public static void AnswerOnQuestions(IEnumerable<Question> questions)
        {
            foreach (var question in questions)
            {
                var answer = ChooseAnswer();
                AnswerOnQuestion(question, answer);
            }
        }
    }
}
