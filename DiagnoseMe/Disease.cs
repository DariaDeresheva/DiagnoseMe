using System;
using System.Collections.Generic;
using System.Linq;

namespace DiagnoseMe
{
    public class Disease
    {
        public IReadOnlyList<int> NumbersOfSymptoms { get; set; } = new List<int>();

        public string Name { get; set; } = string.Empty;

        public static Disease Parse(string value)
        {
            var valueSplitted = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int number;
            var numbers = valueSplitted.Where(str => int.TryParse(str, out number)).ToList();
            var name = string.Join(@" ", valueSplitted.Except(numbers));
            return new Disease {NumbersOfSymptoms = new List<int>(numbers.Select(int.Parse)), Name = name};
        }
    }
}
