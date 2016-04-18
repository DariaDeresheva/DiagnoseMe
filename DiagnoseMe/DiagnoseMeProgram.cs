using System;

namespace DiagnoseMe
{
    internal class DiagnoseMeProgram
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(@"Самый вероятный диагноз: " + Doctor.FindHumanDiagnose());
            Console.ReadLine();
        }
    }
}
