# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The BraveSearch SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models web search and news search capabilities via Brave Search.

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsSearchTool()` | `BraveWebSearch` | Searches the web for current information on a query. |
| `AsNewsTool()` | `BraveNewsSearch` | Searches for recent news articles on a query. |

## Usage

```csharp
using BraveSearch;
using Microsoft.Extensions.AI;

var brave = new BraveSearchClient(apiKey);

// Create tools
var tools = new[]
{
    brave.AsSearchTool(count: 5),
    brave.AsNewsTool(count: 5),
};

// Use with any IChatClient
var response = await chatClient.GetResponseAsync(
    "What are the latest developments in AI?",
    new ChatOptions { Tools = tools });
```

## Tool Details

### BraveWebSearch

Searches the web using Brave Search. Returns results with titles, URLs, and text snippets.
Accepts a `count` parameter to limit results (default: 5).

### BraveNewsSearch

Searches Brave Search for recent news articles. Returns results with titles, sources, dates, and snippets.
Accepts a `count` parameter to limit results (default: 5).

```csharp
var tool = brave.AsNewsTool(count: 10);
```
