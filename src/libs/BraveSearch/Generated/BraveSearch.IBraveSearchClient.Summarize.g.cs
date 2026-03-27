#nullable enable

namespace BraveSearch
{
    public partial interface IBraveSearchClient
    {
        /// <summary>
        /// Summarizer<br/>
        /// Get an AI-generated summary for a search query.<br/>
        /// Requires a summarizer key obtained from the web search endpoint<br/>
        /// (pass summary=true to web search first). The key is found in the<br/>
        /// web search response under the summarizer field.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="entityInfo">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BraveSearch.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BraveSearch.SummarizerSearchResult> SummarizeAsync(
            string key,
            bool? entityInfo = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}