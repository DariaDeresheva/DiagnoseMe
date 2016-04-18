using System.Collections.Generic;
using System.IO;

namespace DiagnoseMe
{
    public class Doctor
    {
        public const string FileWithQuestions = @"D:\DiagnoseMe\Docs\Questions.txt";

        public static IEnumerable<string> GetAllQuestionStrings()
        {
            return File.ReadLines(FileWithQuestions);
        } 
    }
}
