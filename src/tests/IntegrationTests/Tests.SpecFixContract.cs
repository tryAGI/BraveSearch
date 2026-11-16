namespace BraveSearch.IntegrationTests;

/// <summary>
/// What generate.sh does to the spec, checked without an API key.
///
/// Brave publishes no OpenAPI spec, so openapi.yaml is maintained by hand and generate.sh passes
/// `--security-scheme ApiKey:Header:X-Subscription-Token`. Lose that and the key stops being sent
/// under the one header Brave accepts, which no amount of compiling would reveal.
///
/// Every other test here needs a key and reports inconclusive without one, so the suite printed
/// `Skipped!` and exited 0 - which looks exactly like a passing run. These two do not touch the
/// network.
/// </summary>
[TestClass]
public class SpecFixContractTests
{
    [TestMethod]
    public void TheClientSendsTheCredentialTheSpecFixAsksFor()
    {
        using var client = new global::BraveSearch.BraveSearchClient("test-key");

        var authorization = client.Authorizations.SingleOrDefault(
            x => x.Type == "ApiKey" && x.Location == "Header");

        Assert.IsNotNull(
            authorization,
            $"Expected one ApiKey credential in the Header, found: " +
            string.Join(", ", client.Authorizations.Select(x => $"{x.Type}/{x.Location}/{x.Name}")) +
            ". This comes from the --security-scheme in generate.sh; if a spec refresh changed it, " +
            "fix the flag rather than the test.");
        Assert.AreEqual("X-Subscription-Token", authorization.Name);
        Assert.AreEqual("test-key", authorization.Value);
    }

    [TestMethod]
    public void TheDefaultBaseUrlIsTheOneTheSpecDeclares()
    {
        Assert.AreEqual("https://api.search.brave.com/res/v1", global::BraveSearch.BraveSearchClient.DefaultBaseUrl);
    }
}
