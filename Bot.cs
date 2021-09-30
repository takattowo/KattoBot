using System.Threading.Tasks;

namespace KattoBot
{
    class Bot
    {
        public static Task Main(string[] args)
            => Startup.RunAsync(args);
    }
}
