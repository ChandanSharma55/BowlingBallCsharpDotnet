using BowlingBall;
using BowlingBall.Managers;
using BowlingBall.Models;
using BowlingBall.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace BowlingBall
{
    public class BowlingBallMain
    {
        private readonly IRollManager _rollManager;
        public BowlingBallMain(IRollManager rollManager)
        {
            _rollManager = rollManager;
        }
        
        public void RunApplication()
        {
            _rollManager.StrikeRoll();
            _rollManager.OpenOrSpareRoll(9, 1);
            _rollManager.OpenOrSpareRoll(5, 5);
            _rollManager.OpenOrSpareRoll(7, 2);
            _rollManager.StrikeRoll();
            _rollManager.StrikeRoll();
            _rollManager.StrikeRoll();
            _rollManager.OpenOrSpareRoll(9, 0);
            _rollManager.OpenOrSpareRoll(8, 2);
            _rollManager.LastRoll(9, 1, 10);


            Console.WriteLine(_rollManager.CalculateScore());
        }

        public static void Main(string[] args)
        {
            var host = ServiceRegistration.CreateHostBuilder(args).Build();
            host.Services.GetRequiredService<BowlingBallMain>().RunApplication();
        }
    }
}