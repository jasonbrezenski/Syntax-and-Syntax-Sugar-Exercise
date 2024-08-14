namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            SyntaxSugarExercise();
        }

        public static void SyntaxSugarExercise()
        {
            //int answer = 4;  //explicit typing
            //string response;  //explicit typing
            
            //if (answer < 9)
            //{
                //response = $"{answer} is less than nine.";
            //}
            //else
            //{
                //response = $"{answer} is greater than or equal to nine.";
            //}

            var answer = 4;  //inferred typing
            var answer2 = 9;  //inferred typing

            var response = answer < answer2
                ? $"{answer} is less than {answer2}."
                : $"{answer} is greater than or equal to {answer2}.";
            
            Console.WriteLine(response);
        }
    }
}
