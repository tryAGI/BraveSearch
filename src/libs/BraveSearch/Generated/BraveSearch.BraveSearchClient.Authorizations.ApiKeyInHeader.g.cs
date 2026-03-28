
#nullable enable

namespace BraveSearch
{
    public sealed partial class BraveSearchClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::BraveSearch.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "X-Subscription-Token",
                Value = apiKey,
            });
        }
    }
}