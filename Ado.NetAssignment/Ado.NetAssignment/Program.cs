namespace Ado.NetAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            new Student().GetStudentCount();
            new Student().GetMaxMinAvgScore("English");
            new Student().GetHighestScorer("English");
            new Student().GetLowestScorer("English");
            new Student().GetMaxMinAvgScore("Hindi");
            new Student().GetHighestScorer("Hindi");
            new Student().GetLowestScorer("Hindi");
            new Student().GetMaxMinAvgScore("Maths");
            new Student().GetHighestScorer("Maths");
            new Student().GetLowestScorer("Maths");
            new Student().GetMaxMinAvgScore("Computer");
            new Student().GetHighestScorer("Computer");
            new Student().GetLowestScorer("Computer");
        }        
    }
}
