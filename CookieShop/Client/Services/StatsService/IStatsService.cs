using System;
using System.Threading.Tasks;

namespace CookieShop.Client.Services.StatsService
{
    public interface IStatsService
    {
        Task GetVisits();

        Task IncrememtVisits();
    }
}
