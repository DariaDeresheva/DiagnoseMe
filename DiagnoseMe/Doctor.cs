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
            return GetAllQuestionStrings().Select(Question.Parse);
        }

        public static IEnumerable<Disease> GetAllDiseases()
        {
            return GetAllDiseaseStrings().Select(Disease.Parse);
        }

        public static Disease FindDisease(IEnumerable<Question> answeredQuestions, IEnumerable<Disease> diseases)
        {
            var answeredAsTrueNumbers =
                answeredQuestions.Where(question => question.IsAnsweredAsTrue).Select(question => question.Number);

            return
                diseases.OrderByDescending(disease => disease.NumbersOfSymptoms.Intersect(answeredAsTrueNumbers).Count())
                    .First();
        }

        public static string FindHumanDiagnose()
        {
            var questions = GetAllQuestions();
            var answeredQuestions = Human.AnswerOnQuestions(questions);
            var diseases = GetAllDiseases();
            var mostSuitableDisease = FindDisease(answeredQuestions, diseases);
            return mostSuitableDisease.Name;
        }
    }
}
