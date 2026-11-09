#nullable enable

using System.CommandLine;
using BraveSearch.CLI;
using BraveSearch.CLI.Commands;

var rootCommand = new RootCommand(@"CLI tool for the BraveSearch SDK.");
rootCommand.Options.Add(CliOptions.ApiKey);
rootCommand.Options.Add(CliOptions.BaseUrl);
rootCommand.Options.Add(CliOptions.Json);
rootCommand.Options.Add(CliOptions.Output);
rootCommand.Options.Add(CliOptions.OutputDirectory);
rootCommand.Subcommands.Add(AuthCommand.Create());
rootCommand.Subcommands.Add(DefaultApiGroupCommand.Create());
rootCommand.Subcommands.Add(CliCompletion.CreateCommand(rootCommand, @"brave-search"));

return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);