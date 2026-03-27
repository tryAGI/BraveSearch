#nullable enable

namespace BraveSearch;

public partial class BraveSearchClient
{
    // Brave Search uses "X-Subscription-Token" header instead of "Authorization: Bearer".
    // The generated code sends "Authorization: Bearer <key>" but Brave Search
    // expects the API key in the "X-Subscription-Token" header.
    partial void PrepareRequest(
        global::System.Net.Http.HttpClient client,
        global::System.Net.Http.HttpRequestMessage request)
    {
        if (request.Headers.Authorization is { Scheme: "Bearer", Parameter: { } apiKey })
        {
            request.Headers.Authorization = null;
            request.Headers.TryAddWithoutValidation("X-Subscription-Token", apiKey);
        }
    }
}
