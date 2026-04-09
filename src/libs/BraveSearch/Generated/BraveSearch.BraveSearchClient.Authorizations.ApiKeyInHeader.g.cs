
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

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "X-Subscription-Token")
                {
                    Authorizations.RemoveAt(i);
                }
            }

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