#nullable enable

namespace BraveSearch
{
    public partial interface IBraveSearchClient
    {
        /// <summary>
        /// Video Search<br/>
        /// Search for videos using Brave Search.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BraveSearch.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BraveSearch.VideoSearchResponse> VideoSearchAsync(
            string q,
            string? country = default,
            string? searchLang = default,
            int? count = default,
            int? offset = default,
            global::BraveSearch.VideoSearchSafesearch? safesearch = default,
            string? freshness = default,
            bool? spellcheck = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}