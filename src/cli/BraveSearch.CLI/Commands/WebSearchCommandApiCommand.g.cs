#nullable enable

using System.CommandLine;

namespace BraveSearch.CLI.Commands;

internal static partial class WebSearchCommandApiCommand
{
    private static Option<string> Q { get; } = new(
        name: @"--q")
    {
        Description = @"The search query string. Maximum 400 characters and 50 words.",
        Required = true,
    };

    private static Option<string?> Country { get; } = new(
        name: @"--country")
    {
        Description = @"Country code for search results (ISO 3166-1 alpha-2).
Used to boost results for the specified country.
",
    };

    private static Option<string?> SearchLang { get; } = new(
        name: @"--search-lang")
    {
        Description = @"Language code for search results (ISO 639-1).
Used to boost results in the specified language.
",
    };

    private static Option<string?> UiLang { get; } = new(
        name: @"--ui-lang")
    {
        Description = @"User interface language preference (ISO 639-1).",
    };

    private static Option<int?> Count { get; } = new(
        name: @"--count")
    {
        Description = @"Number of results to return (1-20). Default is 20.",
    };

    private static Option<int?> Offset { get; } = new(
        name: @"--offset")
    {
        Description = @"Zero-based offset for pagination. Maximum 9.",
    };

    private static Option<global::BraveSearch.WebSearchSafesearch?> Safesearch { get; } = new(
        name: @"--safesearch")
    {
        Description = @"Filter adult content. ""off"", ""moderate"", or ""strict"".",
    };

    private static Option<string?> Freshness { get; } = new(
        name: @"--freshness")
    {
        Description = @"Filter results by discovery time. Values: pd (past day),
pw (past week), pm (past month), py (past year), or a date range
in format YYYY-MM-DDtoYYYY-MM-DD.
",
    };

    private static Option<bool?> TextDecorations { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--text-decorations",
        description: @"Whether to include bold/highlighting markers in text snippets.");

    private static Option<bool?> Spellcheck { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--spellcheck",
        description: @"Whether to enable spellcheck suggestions.");

    private static Option<string?> ResultFilter { get; } = new(
        name: @"--result-filter")
    {
        Description = @"Comma-separated list of result types to include.
Available types: discussions, faq, infobox, news, query, summarizer, videos, web, locations.
",
    };

    private static Option<string?> GogglesId { get; } = new(
        name: @"--goggles-id")
    {
        Description = @"A Goggle URL to re-rank search results.
Goggles allow custom ranking of results.
",
    };

    private static Option<global::BraveSearch.WebSearchUnits?> Units { get; } = new(
        name: @"--units")
    {
        Description = @"Unit system for displaying measurements. ""metric"" or ""imperial"".",
    };

    private static Option<bool?> ExtraSnippets { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--extra-snippets",
        description: @"Whether to return up to 5 extra snippets per result.");

    private static Option<bool?> Summary { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--summary",
        description: @"Whether to include a summarizer key in the response.
The key can be used with the Summarizer endpoint.
Requires subscription with summarizer access.
");

                    private static string FormatResponse(ParseResult parseResult, global::BraveSearch.WebSearchResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::BraveSearch.WebSearchResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"web-search", @"Web Search
Search the web using Brave Search. Returns web results, videos, news,
locations, infoboxes, discussions, FAQs, and related content.
");
                        command.Options.Add(Q);
                        command.Options.Add(Country);
                        command.Options.Add(SearchLang);
                        command.Options.Add(UiLang);
                        command.Options.Add(Count);
                        command.Options.Add(Offset);
                        command.Options.Add(Safesearch);
                        command.Options.Add(Freshness);
                        command.Options.Add(TextDecorations);
                        command.Options.Add(Spellcheck);
                        command.Options.Add(ResultFilter);
                        command.Options.Add(GogglesId);
                        command.Options.Add(Units);
                        command.Options.Add(ExtraSnippets);
                        command.Options.Add(Summary);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var q = parseResult.GetRequiredValue(Q);
                        var country = parseResult.GetValue(Country);
                        var searchLang = parseResult.GetValue(SearchLang);
                        var uiLang = parseResult.GetValue(UiLang);
                        var count = parseResult.GetValue(Count);
                        var offset = parseResult.GetValue(Offset);
                        var safesearch = parseResult.GetValue(Safesearch);
                        var freshness = parseResult.GetValue(Freshness);
                        var textDecorations = parseResult.GetValue(TextDecorations);
                        var spellcheck = parseResult.GetValue(Spellcheck);
                        var resultFilter = parseResult.GetValue(ResultFilter);
                        var gogglesId = parseResult.GetValue(GogglesId);
                        var units = parseResult.GetValue(Units);
                        var extraSnippets = parseResult.GetValue(ExtraSnippets);
                        var summary = parseResult.GetValue(Summary);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.WebSearchAsync(
                                    q: q,
                                    country: country,
                                    searchLang: searchLang,
                                    uiLang: uiLang,
                                    count: count,
                                    offset: offset,
                                    safesearch: safesearch,
                                    freshness: freshness,
                                    textDecorations: textDecorations,
                                    spellcheck: spellcheck,
                                    resultFilter: resultFilter,
                                    gogglesId: gogglesId,
                                    units: units,
                                    extraSnippets: extraSnippets,
                                    summary: summary,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::BraveSearch.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}