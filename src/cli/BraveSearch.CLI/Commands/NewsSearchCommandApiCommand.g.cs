#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BraveSearch.CLI.Commands;

internal static partial class NewsSearchCommandApiCommand
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
        Description = @"Country code for results (ISO 3166-1 alpha-2).",
    };

    private static Option<string?> SearchLang { get; } = new(
        name: @"--search-lang")
    {
        Description = @"Language code for results (ISO 639-1).",
    };

    private static Option<int?> Count { get; } = new(
        name: @"--count")
    {
        Description = @"Number of results to return (1-50). Default is 20.",
    };

    private static Option<int?> Offset { get; } = new(
        name: @"--offset")
    {
        Description = @"Zero-based offset for pagination.",
    };

    private static Option<global::BraveSearch.NewsSearchSafesearch?> Safesearch { get; } = new(
        name: @"--safesearch")
    {
        Description = @"Filter adult content.",
    };

    private static Option<string?> Freshness { get; } = new(
        name: @"--freshness")
    {
        Description = @"Filter by time (pd, pw, pm, py, or YYYY-MM-DDtoYYYY-MM-DD).",
    };

    private static Option<bool?> Spellcheck { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--spellcheck",
        description: @"Whether to enable spellcheck suggestions.");

    private static Option<bool?> ExtraSnippets { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--extra-snippets",
        description: @"Whether to return extra snippets per result.");

                    private static string FormatResponse(ParseResult parseResult, global::BraveSearch.NewsSearchResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::BraveSearch.NewsSearchResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"news-search", @"News Search
Search for news articles using Brave Search.");
                        command.Options.Add(Q);
                        command.Options.Add(Country);
                        command.Options.Add(SearchLang);
                        command.Options.Add(Count);
                        command.Options.Add(Offset);
                        command.Options.Add(Safesearch);
                        command.Options.Add(Freshness);
                        command.Options.Add(Spellcheck);
                        command.Options.Add(ExtraSnippets);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var q = parseResult.GetRequiredValue(Q);
                        var country = parseResult.GetValue(Country);
                        var searchLang = parseResult.GetValue(SearchLang);
                        var count = parseResult.GetValue(Count);
                        var offset = parseResult.GetValue(Offset);
                        var safesearch = parseResult.GetValue(Safesearch);
                        var freshness = parseResult.GetValue(Freshness);
                        var spellcheck = parseResult.GetValue(Spellcheck);
                        var extraSnippets = parseResult.GetValue(ExtraSnippets);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.NewsSearchAsync(
                                    q: q,
                                    country: country,
                                    searchLang: searchLang,
                                    count: count,
                                    offset: offset,
                                    safesearch: safesearch,
                                    freshness: freshness,
                                    spellcheck: spellcheck,
                                    extraSnippets: extraSnippets,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::BraveSearch.SourceGenerationContext.Default,
                                        @"Results",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::BraveSearch.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}