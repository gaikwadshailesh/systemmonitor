using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using SystemMonitor.Models;
using System.Threading.Tasks;

namespace SystemMonitor.Services
{
    public class SystemStatsService : ISystemStatsService
    {
        private readonly PerformanceCounter? _cpuCounter;
        
        public SystemStatsService()
        {
            if (RuntimeInformation.IsWindows())
            {
                _cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                _cpuCounter.NextValue(); // First call will always return 0
            }
        }

        public async Task<SystemStats> GetSystemStatsAsync()
        {
            var stats = new SystemStats();
            
            // Get CPU usage
            if (RuntimeInformation.IsWindows() && _cpuCounter != null)
            {
                stats.CpuUsagePercentage = Math.Round(_cpuCounter.NextValue(), 2);
            }
            
            // Get memory information
            var totalMemory = GC.GetGCMemoryInfo();
            stats.TotalMemoryMB = Math.Round(totalMemory.TotalAvailableMemoryBytes / 1024.0 / 1024.0, 2);
            stats.UsedMemoryMB = Math.Round((totalMemory.TotalAvailableMemoryBytes - totalMemory.MemoryLoadBytes) / 1024.0 / 1024.0, 2);
            stats.AvailableMemoryMB = Math.Round(totalMemory.MemoryLoadBytes / 1024.0 / 1024.0, 2);
            
            // Get system uptime
            stats.Uptime = TimeSpan.FromMilliseconds(Environment.TickCount64);
            
            return stats;
        }
    }
} 