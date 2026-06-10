#nullable enable

using System.CommandLine;

namespace BraveSearch.CLI.Commands;

internal static partial class SuggestCommandApiCommand
{
    private static Option<string> Q { get; } = new(
        name: @"--q")
    {
        Description = @"The partial search query for suggestions.",
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
        Description = @"Number of suggestions to return.",
    };

    private static Option<bool?> Rich { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--rich",
        description: @"Whether to include rich suggestions with descriptions and images.");

                    private static string FormatResponse(ParseResult parseResult, global::BraveSearch.SuggestSearchResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::BraveSearch.SuggestSearchResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"suggest", @"Suggest (Autocomplete)
Get autocomplete suggestions for a partial search query.");
                        command.Options.Add(Q);
                        command.Options.Add(Country);
                        command.Options.Add(SearchLang);
                        command.Options.Add(Count);
                        command.Options.Add(Rich);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var q = parseResult.GetRequiredValue(Q);
                        var country = parseResult.GetValue(Country);
                        var searchLang = parseResult.GetValue(SearchLang);
                        var count = parseResult.GetValue(Count);
                        var rich = parseResult.GetValue(Rich);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SuggestAsync(
                                    q: q,
                                    country: country,
                                    searchLang: searchLang,
                                    count: count,
                                    rich: rich,
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