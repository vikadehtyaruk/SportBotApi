using WebApplication1.Constant;
using WebApplication1.Model;

namespace WebApplication1.Clients
{
    public class DeleteClient
    {
        public static string DeleteExercises(long userid, string name)
        {

            //Console.WriteLine(Environment.CurrentDirectory);
            string result = "There is no such exercise in the list:(";
            List<FavoriteExercises> favouriteExercises = new List<FavoriteExercises>();
            StreamReader streamReader = new StreamReader(Constants.path);
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(Constants.path);
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                var dsr = Newtonsoft.Json.JsonConvert.DeserializeObject<FavoriteExercises>(line);
                if (dsr._userid == userid && dsr._name == name)
                {
                    result = "Exercise removed successfully!";
                }
                else
                {
                    favouriteExercises.Add(dsr);
                }
            }
            streamReader.Close();
            File.WriteAllText(Constants.path, string.Empty);
            foreach (var fa in favouriteExercises)
            {
                var srl = Newtonsoft.Json.JsonConvert.SerializeObject(fa);
                using (StreamWriter sw = new StreamWriter(Constants.path, true))
                {
                    sw.WriteLine(srl);
                }
            }
            return result;
        }
        public static async Task<string> GetPath(string fileName)
        {
            //string pathh = Directory.GetCurrentDirectory();
            string fullPathOnly = Path.GetFullPath(fileName);
            //string target = @"telegram.txt";
            Console.WriteLine("The current directory is {0}", fullPathOnly);
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }
            Console.WriteLine(fullPathOnly);
            return fullPathOnly;
        }


    }
}
