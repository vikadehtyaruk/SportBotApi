using WebApplication1.Constant;
using WebApplication1.Clients;
using WebApplication1.Model;
using Newtonsoft.Json;
using System;
using System.IO;
namespace WebApplication1.Clients
{
    public class ExerciseClient
    {
        private HttpClient _client;
        private static string _address;
        private static string _apikey;
        private List<string> people = new List<string>();
        public ExerciseClient()
        {
            _client = new HttpClient();
            _address = Constants.address;
            _apikey = Constants.apikey;
            _client.BaseAddress = new Uri(_address);
            _client.DefaultRequestHeaders.Add("X-RapidAPI-Key", _apikey);
        }
        public async Task<List<Sport>> GetExerciseByNameAsync(string Name)
        {
            var response = await _client.GetAsync($"exercises/name/{Name}");
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<List<Sport>>(content);
            return result;
        }
        public async Task<List<Sport>> GetExerciseByTargetAsync(string Target)
        {
            var response = await _client.GetAsync($"exercises/target/{Target}");
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<List<Sport>>(content);
            return result;
        }
        public async Task<List<Sport>> GetExerciseByEquipmentAsync(string Equipment)
        {
            var response = await _client.GetAsync($"exercises/equipment/{Equipment}");
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<List<Sport>>(content);
            return result;
        }
        public async Task<List<Sport>> GetExerciseByBodyPartAsync(string BodyPart)
        {
            var response = await _client.GetAsync($"exercises/bodyPart/{BodyPart}");
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<List<Sport>>(content);
            return result;
        }
    }
}
