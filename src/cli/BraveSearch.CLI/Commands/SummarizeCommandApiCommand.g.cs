#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BraveSearch.CLI.Commands;

internal static partial class SummarizeCommandApiCommand
{
    private static Option<string> Key { get; } = new(
        name: @"--key")
    {
        Description = @"The summarizer key obtained from a prior web search response.
Get this by passing summary=true to the web search endpoint.
",
        Required = true,
    };

    private static Option<bool?> EntityInfo { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--entity-info",
        description: @"Whether to include entity information in the summary.");

                    private static string FormatResponse(ParseResult parseResult, global::BraveSearch.SummarizerSearchResult value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::BraveSearch.SummarizerSearchResult value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"summarize", @"Summarizer
Get an AI-generated summary for a search query.
Requires a summarizer key obtained from the web search endpoint
(pass summary=true to web search first). The key is found in the
web search response under the summarizer field.
");
                        command.Options.Add(Key);
                        command.Options.Add(EntityInfo);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var key = parseResult.GetRequiredValue(Key);
                        var entityInfo = parseResult.GetValue(EntityInfo);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SummarizeAsync(
                                    key: key,
                                    entityInfo: entityInfo,
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