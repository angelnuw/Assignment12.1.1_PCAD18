namespace Assignment12._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var checker = new RansomChecker();

            Console.WriteLine(checker.CanConstruct("a", "b"));      // false
            Console.WriteLine(checker.CanConstruct("aa", "ab"));    // false
            Console.WriteLine(checker.CanConstruct("aa", "aab"));   // true
        }
    }
}
