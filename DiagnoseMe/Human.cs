using System;

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
    }
}
