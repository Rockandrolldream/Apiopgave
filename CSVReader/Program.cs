using CSVReader.Model;

namespace CSVReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BallingdatabaseContext context = new BallingdatabaseContext();
            IQueryable<Cereal> output;
            using (var reader = new StreamReader(@"C:/Users/KOM/source/repos/Apiopgave/CSVReader/Csvfile/cereal_unclean.csv"))
            {
               
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    Console.WriteLine(values[0]);

                    output = context.Cereals.Where(m => m.Name == values[0]);
                    if (output == null)
                    {
                        Cereal cereal = new Cereal() { Name = values[0] , Mfr = values[1] , Type = values[2] , Calories = values[3] , Protein = values[4] };
                    }


                }
            }
        }
    }
}