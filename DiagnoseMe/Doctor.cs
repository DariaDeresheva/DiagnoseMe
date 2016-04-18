using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DiagnoseMe
{
    public class Doctor
    {
        public const string FileWithQuestions = @"D:\DiagnoseMe\Docs\Questions.txt";

        public static IEnumerable<string> GetAllQuestionStrings()
        {
            return File.ReadLines(FileWithQuestions);
        }

        public static IEnumerable<Question> GetAllQuestions()
        {
            return File.ReadLines(FileWithQuestions).Select(Question.Parse);
        }
    }
}
