namespace Billing;

public class Program
{
    static async Task Main(string[] args)
    {
        Console.Title = "Billing";

        var endpointConfiguration = new EndpointConfiguration("Billing");

        var transport = endpointConfiguration.UseTransport<LearningTransport>();

        var endpointInstance = await Endpoint.Start(endpointConfiguration)
            .ConfigureAwait(false);

        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();

        await endpointInstance.Stop()
            .ConfigureAwait(false);
    }
}