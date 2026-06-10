#nullable enable

using System.CommandLine;

namespace BraveSearch.CLI.Commands;

internal static class DefaultApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"default", @"default endpoint commands.");
                         command.Subcommands.Add(ImageSearchCommandApiCommand.Create());
                         command.Subcommands.Add(NewsSearchCommandApiCommand.Create());
                         command.Subcommands.Add(SuggestCommandApiCommand.Create());
                         command.Subcommands.Add(SummarizeCommandApiCommand.Create());
                         command.Subcommands.Add(VideoSearchCommandApiCommand.Create());
                         command.Subcommands.Add(WebSearchCommandApiCommand.Create());
        return command;
    }
}