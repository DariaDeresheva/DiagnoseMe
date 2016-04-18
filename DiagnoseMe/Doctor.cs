using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DiagnoseMe
{
    public class Doctor
    {
        public const string FileWithQuestions = @"D:\DiagnoseMe\Docs\Questions.txt";

        public const string FileWithDiseases = @"D:\DiagnoseMe\Docs\Diseases.txt";

        public static IEnumerable<string> GetAllQuestionStrings()
        {
            return File.ReadLines(FileWithQuestions);
        }

        public static IEnumerable<string> GetAllDiseaseStrings()
        {
            return File.ReadLines(FileWithDiseases);
        }

        public static IEnumerable<Question> GetAllQuestions()
        {
            return File.ReadLines(FileWithQuestions).Select(Question.Parse);
        }

        public static IEnumerable<Disease> GetAllDiseases()
        {
            return File.ReadLines(FileWithDiseases).Select(Disease.Parse);
        }
    }
}
