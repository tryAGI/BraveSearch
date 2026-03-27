# Microsoft.Extensions.AI Integration

BraveSearch provides `AIFunction` tools compatible with
[Microsoft.Extensions.AI](https://www.nuget.org/packages/Microsoft.Extensions.AI),
allowing any `IChatClient` to perform web and news searches via Brave Search.

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
