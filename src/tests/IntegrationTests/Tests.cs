namespace BraveSearch.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static BraveSearchClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("BRAVESEARCH_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("BRAVESEARCH_API_KEY environment variable is not found.");

        var client = new BraveSearchClient(apiKey);
        
        return client;
    }
}
