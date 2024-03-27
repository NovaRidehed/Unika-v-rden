namespace Unika_värden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Unique
            string[] uniqueTestData = { "a", "b", "c", "d", "a", "a", "c" };
            Console.WriteLine("Demonstration av Unique:");
            Console.WriteLine("Testdata: " + string.Join(",", uniqueTestData));
            List<string> uniqueResult = Unique(uniqueTestData);
            Console.WriteLine("Resultat: " + string.Join(",", uniqueResult));
            Console.WriteLine();
        }
        public static List<string> Unique(string[] strings)
        {
            List<string> result = new List<string>();
            // TOOD
            int antal = strings.Length;
            for (int i = 0; i < (antal -1); i++)
            {
                int samma = 0;
                for(int j = 0; j < antal; j++)
                {
                    if(i == j)
                    {

                    }
                    else if(strings[j] == strings[i])
                    {
                        samma++;
                    }
                }
                if(samma == 0)
                {
                    result.Add(strings[i]);
                }
            }
            return result;
        }
    }
}