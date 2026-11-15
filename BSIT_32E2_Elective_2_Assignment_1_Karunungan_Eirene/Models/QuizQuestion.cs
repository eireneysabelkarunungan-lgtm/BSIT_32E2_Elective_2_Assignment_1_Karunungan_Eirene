namespace BSIT_32E2_Elective_2_Assignment_1.Models
{
    public class QuizQuestion
    {
        public int Number { get; set; }
        public string Question { get; set; } = string.Empty;
        public Dictionary<char, string> Options { get; set; } = new();
        public char CorrectAnswer { get; set; }
        public string Explanation { get; set; } = string.Empty;
    }
}