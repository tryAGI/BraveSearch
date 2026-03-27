using Microsoft.Extensions.AI;

namespace BraveSearch;

/// <summary>
/// Extensions for using BraveSearchClient as an MEAI tool with any IChatClient.
/// </summary>
public static class BraveSearchToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps Brave web search,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Brave Search client to use for searches.</param>
    /// <param name="count">Maximum number of search results to return (default: 5).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsSearchTool(
        this BraveSearchClient client,
        int count = 5)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string query, CancellationToken cancellationToken) =>
            {
                var response = await client.WebSearchAsync(
                    q: query,
                    count: count,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatWebSearchResponse(response);
            },
            name: "BraveWebSearch",
            description: "Searches the web using Brave Search for current information on a given query. Returns relevant results with titles, URLs, and text snippets.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps Brave news search,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Brave Search client to use for news searches.</param>
    /// <param name="count">Maximum number of news results to return (default: 5).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsNewsTool(
        this BraveSearchClient client,
        int count = 5)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string query, CancellationToken cancellationToken) =>
            {
                var response = await client.NewsSearchAsync(
                    q: query,
                    count: count,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatNewsSearchResponse(response);
            },
            name: "BraveNewsSearch",
            description: "Searches Brave Search for recent news articles on a given query. Returns news results with titles, sources, dates, and snippets.");
    }

    private static string FormatWebSearchResponse(WebSearchResponse response)
    {
        var parts = new List<string>();

        if (response.Web?.Results is { Count: > 0 })
        {
            parts.Add("Sources:");
            foreach (var result in response.Web.Results)
            {
                var entry = $"- [{result.Title}]({result.Url})";
                if (!string.IsNullOrWhiteSpace(result.Description))
                {
                    entry += $": {result.Description}";
                }

                parts.Add(entry);
            }
        }

        return string.Join("\n", parts);
    }

    private static string FormatNewsSearchResponse(NewsSearchResponse response)
    {
        var parts = new List<string>();

        if (response.Results is { Count: > 0 })
        {
            parts.Add("News:");
            foreach (var result in response.Results)
            {
                var entry = $"- [{result.Title}]({result.Url})";
                if (!string.IsNullOrWhiteSpace(result.Source))
                {
                    entry += $" ({result.Source})";
                }
                if (!string.IsNullOrWhiteSpace(result.Age))
                {
                    entry += $" [{result.Age}]";
                }
                if (!string.IsNullOrWhiteSpace(result.Description))
                {
                    entry += $": {result.Description}";
                }

                parts.Add(entry);
            }
        }

        return string.Join("\n", parts);
    }
}
