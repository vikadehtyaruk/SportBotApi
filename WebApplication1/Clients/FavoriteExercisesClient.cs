using WebApplication1.Model;
using Newtonsoft.Json;
using WebApplication1.Constant;

namespace WebApplication1.Clients
{
    public class ListClient
    {
        private HttpClient _client;

        public ListClient()
        {
            _client = new HttpClient();  
        }
        public static void ListofFavExercises(string name, long userid)
        {
            List<FavoriteExercises> favourites = new List<FavoriteExercises>();
            StreamReader streamReader = new StreamReader(Constants.path);
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                var exer = Newtonsoft.Json.JsonConvert.DeserializeObject<FavoriteExercises>(line);
                if (line.Contains(name))
                {
                    line = null;
                }
                else
                {
                    favourites.Add(exer);
                }
            }
            streamReader.Close();
            File.WriteAllText(Constants.path, string.Empty);
            FavoriteExercises fav = new FavoriteExercises()
            {
                _name = name,
                _userid = userid
            };
            favourites.Add(fav);
            foreach (var favour in favourites)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(favour);
                using (StreamWriter sw = new StreamWriter(Constants.path, true))
                {
                    sw.WriteLine(json);
                }
            }
        }
    }
}
