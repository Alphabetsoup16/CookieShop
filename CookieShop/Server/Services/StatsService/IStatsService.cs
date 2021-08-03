using System;
using System.Threading.Tasks;

namespace CookieShop.Server.Services.StatsService
{
    public interface IStatsService
    {
        Task<int> GetVisits();

        Task IncrementVisits();
    }
}
