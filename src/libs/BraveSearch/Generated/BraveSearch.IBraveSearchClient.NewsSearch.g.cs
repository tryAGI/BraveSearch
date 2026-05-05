#nullable enable

namespace BraveSearch
{
    public partial interface IBraveSearchClient
    {
        /// <summary>
        /// News Search<br/>
        /// Search for news articles using Brave Search.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="country">
        /// Default Value: us
        /// </param>
        /// <param name="searchLang">
        /// Default Value: en
        /// </param>
        /// <param name="count">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="safesearch">
        /// Default Value: moderate
        /// </param>
        /// <param name="freshness"></param>
        /// <param name="spellcheck">
        /// Default Value: true
        /// </param>
        /// <param name="extraSnippets">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BraveSearch.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BraveSearch.NewsSearchResponse> NewsSearchAsync(
            string q,
            string? country = default,
            string? searchLang = default,
            int? count = default,
            int? offset = default,
            global::BraveSearch.NewsSearchSafesearch? safesearch = default,
            string? freshness = default,
            bool? spellcheck = default,
            bool? extraSnippets = default,
            global::BraveSearch.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// News Search<br/>
        /// Search for news articles using Brave Search.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="country">
        /// Default Value: us
        /// </param>
        /// <param name="searchLang">
        /// Default Value: en
        /// </param>
        /// <param name="count">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="safesearch">
        /// Default Value: moderate
        /// </param>
        /// <param name="freshness"></param>
        /// <param name="spellcheck">
        /// Default Value: true
        /// </param>
        /// <param name="extraSnippets">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BraveSearch.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BraveSearch.AutoSDKHttpResponse<global::BraveSearch.NewsSearchResponse>> NewsSearchAsResponseAsync(
            string q,
            string? country = default,
            string? searchLang = default,
            int? count = default,
            int? offset = default,
            global::BraveSearch.NewsSearchSafesearch? safesearch = default,
            string? freshness = default,
            bool? spellcheck = default,
            bool? extraSnippets = default,
            global::BraveSearch.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}