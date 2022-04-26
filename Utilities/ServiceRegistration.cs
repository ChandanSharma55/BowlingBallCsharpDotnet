using BowlingBall;
using BowlingBall.Managers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Utilities
{
    public static class ServiceRegistration
    {
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddScoped<BowlingBallMain>();
                    services.AddScoped<IFrameManager, FrameManager>();
                    services.AddScoped<IRollManager, RollManager>();
                    services.AddScoped<IScoreManager, ScoreManager>();
                });
        }
    }
}
