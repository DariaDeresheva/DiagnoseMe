using System;

namespace DiagnoseMe
{
    public class Human
    {
        public static void AnswerOnQuestion(Question question, bool answer)
        {
            question.IsAnsweredAsTrue = answer;
        } 
    }
}
