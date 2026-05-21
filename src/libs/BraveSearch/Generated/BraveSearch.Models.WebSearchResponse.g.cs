
#nullable enable

namespace BraveSearch
{
    /// <summary>
    /// Response from the web search endpoint.
    /// </summary>
    public sealed partial class WebSearchResponse
    {
        /// <summary>
        /// The type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Container for discussion/forum results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        public global::BraveSearch.Discussions? Discussions { get; set; }

        /// <summary>
        /// Container for FAQ results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("faq")]
        public global::BraveSearch.Faq? Faq { get; set; }

        /// <summary>
        /// Container for infobox/knowledge panel results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("infobox")]
        public global::BraveSearch.Infobox? Infobox { get; set; }

        /// <summary>
        /// Container for local/location results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locations")]
        public global::BraveSearch.Locations? Locations { get; set; }

        /// <summary>
        /// Information about how results are mixed/ranked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mixed")]
        public global::BraveSearch.MixedResponse? Mixed { get; set; }

        /// <summary>
        /// Container for news results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("news")]
        public global::BraveSearch.NewsResults? News { get; set; }

        /// <summary>
        /// Information about the original search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public global::BraveSearch.Query? Query { get; set; }

        /// <summary>
        /// Container for video results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videos")]
        public global::BraveSearch.VideoResults? Videos { get; set; }

        /// <summary>
        /// Container for web search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web")]
        public global::BraveSearch.WebSearchResults? Web { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// The type identifier.
        /// </param>
        /// <param name="discussions">
        /// Container for discussion/forum results.
        /// </param>
        /// <param name="faq">
        /// Container for FAQ results.
        /// </param>
        /// <param name="infobox">
        /// Container for infobox/knowledge panel results.
        /// </param>
        /// <param name="locations">
        /// Container for local/location results.
        /// </param>
        /// <param name="mixed">
        /// Information about how results are mixed/ranked.
        /// </param>
        /// <param name="news">
        /// Container for news results.
        /// </param>
        /// <param name="query">
        /// Information about the original search query.
        /// </param>
        /// <param name="videos">
        /// Container for video results.
        /// </param>
        /// <param name="web">
        /// Container for web search results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchResponse(
            string? type,
            global::BraveSearch.Discussions? discussions,
            global::BraveSearch.Faq? faq,
            global::BraveSearch.Infobox? infobox,
            global::BraveSearch.Locations? locations,
            global::BraveSearch.MixedResponse? mixed,
            global::BraveSearch.NewsResults? news,
            global::BraveSearch.Query? query,
            global::BraveSearch.VideoResults? videos,
            global::BraveSearch.WebSearchResults? web)
        {
            this.Type = type;
            this.Discussions = discussions;
            this.Faq = faq;
            this.Infobox = infobox;
            this.Locations = locations;
            this.Mixed = mixed;
            this.News = news;
            this.Query = query;
            this.Videos = videos;
            this.Web = web;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchResponse" /> class.
        /// </summary>
        public WebSearchResponse()
        {
        }

    }
}