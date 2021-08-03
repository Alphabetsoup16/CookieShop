using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazored.LocalStorage;

namespace CookieShop.Client.Services.StatsService
{
    public class StatsService : IStatsService
    {
        private readonly HttpClient _http;

        private readonly ILocalStorageService _localStorage;

        public StatsService(HttpClient http, ILocalStorageService locaStorage)
        {
            _http = http;
            _localStorage = locaStorage;
        }

        public async Task GetVisits()
        {
            int visits = int.Parse(await _http.GetStringAsync("api/Stats"));
            Console.WriteLine($"Visits: {visits}");

        }

        public async Task IncrememtVisits()
        {
            DateTime? lastVisits = await _localStorage.GetItemAsync<DateTime?>("lastVisit");
            if(lastVisits == null || ((DateTime)lastVisits).Date != DateTime.Now.Date)
            {
                await _localStorage.SetItemAsync("lastVisit", DateTime.Now);
                await _http.PostAsync("api/Stats", null);
            }
        }
    }
}
