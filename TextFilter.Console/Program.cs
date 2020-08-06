using System.IO;
using TextFilter.Core;
using System.Text;
using System.Configuration;

namespace TextFilter.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            string filePath = ConfigurationManager.AppSettings["textFilePath"];
            StreamReader file = new StreamReader(filePath);

            MiddleVowelTextFilter middleVowelHandler = new MiddleVowelTextFilter();
            LessThanThreeTextFilter lessThanThreeHandler = new LessThanThreeTextFilter();
            ContainsLetterTTextFilter containsLetterTHandler = new ContainsLetterTTextFilter();

            middleVowelHandler.SetNextFilter(lessThanThreeHandler);
            lessThanThreeHandler.SetNextFilter(containsLetterTHandler);


            string line;
            while ((line = file.ReadLine()) != null)
            {
                var words = Core.TextFilter.RemoveSymbols(line).Split(' ');

                foreach (var word in words)
                {
                    var request = new Request() { Word = word.Trim() };

                    middleVowelHandler.Process(request);

                    if (request.IsValid)
                    {
                        sb.Append(request.Word);
                        sb.Append(" ");
                    }
                }
            }

            file.Close();

            System.Console.WriteLine(sb.ToString().Trim());
            System.Console.ReadLine();
        }
    }
}
