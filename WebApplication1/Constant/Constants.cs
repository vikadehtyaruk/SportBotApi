using System.IO;
using WebApplication1.Clients;

namespace WebApplication1.Constant
{
    public static class Constants
    {
        public static string address = "https://exercisedb.p.rapidapi.com/";
        public static string apikey = "877c460d91mshfa722f4c66ade02p19260bjsn3a9fca77d8e3";
        //public static string path = @"C:\Users\vikad\source\repos\WebApplication1\telegram.txt";
        //public static string target = "telegram.txt";
       //public static string path = Directory.GetCurrentDirectory();
         public static string fileName = @"telegram.txt";
         public static string path = DeleteClient.GetPath(fileName).Result;
        //public static string path = Path.Combine(Environment.CurrentDirectory, @"repos\WebApplication1\", fileName);
        //public static string path = Path.GetFullPath(fileName);
        //public static string path = Path.Combine(Environment.CurrentDirectory,@"repos\WebApplication1\", fileName);
        //public static string path = Path.Combine(Directory.GetCurrentDirectory(), fileName);
        //public static string path = "MyDir\\telegram.txt";


    }

}
