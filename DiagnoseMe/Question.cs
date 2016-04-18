using System;
using System.Linq;

namespace DiagnoseMe
{
    public class Question
    {
        public int Number { get; set; }

        public string Text { get; set; }

        public bool IsAnsweredAsTrue { get; set; }

        public static Question Parse(string value)
        {
            var number = int.Parse(value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).First());
            return new Question { Number = number, Text = value };
        }
    }
}