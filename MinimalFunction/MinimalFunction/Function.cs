using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace CostOverview.App.api;

public class Function
{
    private readonly ILogger<Function> _log;

    public Function(ILogger<Function> log)
    {
        _log = log;
    }


    [Function("TimerFunction")]
    // Triggered to run at 15 and 45 mins after the hour each hour.
    public void Run([TimerTrigger("0 15,45 * * * *", UseMonitor = true, RunOnStartup = false)] TimerInfo myTimer)
    {
        _log.LogInformation("Timer triggered!");
    }
}