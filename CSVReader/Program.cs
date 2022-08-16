namespace CSVReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"C:/Users/KOM/source/repos/Apiopgave/CSVReader/Csvfile/cereal_unclean.csv"))
            {
                List<string> name = new List<string>();
                List<string> mfr = new List<string>();
                List<string> type = new List<string>();
                List<string> calories = new List<string>();
                List<string> protein = new List<string>();
                List<string> fat = new List<string>();
                List<string> sodium = new List<string>(); 
                List<string> fiber = new List<string>();
                List<string> carbo = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    Console.WriteLine(values[0]);
                    name.Add(values[0]);
                    mfr.Add(values[1]);
                }
            }
        }
    }
}