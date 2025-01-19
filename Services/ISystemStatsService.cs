using SystemMonitor.Models;
using System.Threading.Tasks;

namespace SystemMonitor.Services
{
    public interface ISystemStatsService
    {
        Task<SystemStats> GetSystemStatsAsync();
    }
} 