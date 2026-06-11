#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BraveSearch.CLI.Commands;

internal static partial class ImageSearchCommandApiCommand
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
        Description = @"Number of results to return (1-150). Default is 50.",
    };

    private static Option<global::BraveSearch.ImageSearchSafesearch?> Safesearch { get; } = new(
        name: @"--safesearch")
    {
        Description = @"Filter adult content.",
    };

    private static Option<bool?> Spellcheck { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--spellcheck",
        description: @"Whether to enable spellcheck suggestions.");

                    private static string FormatResponse(ParseResult parseResult, global::BraveSearch.ImageSearchResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::BraveSearch.ImageSearchResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"image-search", @"Image Search
Search for images using Brave Search.");
                        command.Options.Add(Q);
                        command.Options.Add(Country);
                        command.Options.Add(SearchLang);
                        command.Options.Add(Count);
                        command.Options.Add(Safesearch);
                        command.Options.Add(Spellcheck);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var q = parseResult.GetRequiredValue(Q);
                        var country = parseResult.GetValue(Country);
                        var searchLang = parseResult.GetValue(SearchLang);
                        var count = parseResult.GetValue(Count);
                        var safesearch = parseResult.GetValue(Safesearch);
                        var spellcheck = parseResult.GetValue(Spellcheck);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ImageSearchAsync(
                                    q: q,
                                    country: country,
                                    searchLang: searchLang,
                                    count: count,
                                    safesearch: safesearch,
                                    spellcheck: spellcheck,
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