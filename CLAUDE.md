# CLAUDE.md -- BraveSearch SDK

## Overview

Auto-generated C# SDK for [Brave Search](https://brave.com/search/api/) -- privacy-focused search API covering web, image, video, and news search, plus AI-powered summaries and autocomplete suggestions.
**No public OpenAPI spec exists** -- `openapi.yaml` was manually created from Brave Search API documentation.

## Build & Test

```bash
dotnet build BraveSearch.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth (converted to X-Subscription-Token header at request time):

```csharp
var client = new BraveSearchClient(apiKey); // BRAVESEARCH_API_KEY env var
```

## Key Files

- `src/libs/BraveSearch/openapi.yaml` -- **Manually maintained** OpenAPI spec (no public spec from Brave)
- `src/libs/BraveSearch/generate.sh` -- Fixes auth scheme in local spec, runs autosdk (no download step)
- `src/libs/BraveSearch/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/BraveSearch/Extensions/BraveSearchClient.Auth.cs` -- Converts Bearer to X-Subscription-Token header
- `src/libs/BraveSearch/Extensions/BraveSearchClient.AsTool.cs` -- MEAI AIFunction tools (AsSearchTool, AsNewsTool)
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

- **No public OpenAPI spec exists** -- `openapi.yaml` was manually created from Brave Search API docs
- All 6 endpoints are GET requests to `https://api.search.brave.com/res/v1`
- Auth uses `X-Subscription-Token` header natively; `generate.sh` converts `apiKey` to `http/bearer`

## Auth Hook

The `PrepareRequest` hook in `Extensions/BraveSearchClient.Auth.cs` converts Bearer to the native header:

```csharp
partial void PrepareRequest(HttpClient client, HttpRequestMessage request)
{
    if (request.Headers.Authorization is { Scheme: "Bearer", Parameter: { } apiKey })
    {
        request.Headers.Authorization = null;
        request.Headers.TryAddWithoutValidation("X-Subscription-Token", apiKey);
    }
}
```

> **Alternative:** Could use `--security-scheme ApiKey:Header:X-Subscription-Token` CLI arg instead of the jq auth conversion + PrepareRequest hook.

## Endpoints

| Endpoint | Method | Description |
|----------|--------|-------------|
| `/web/search` | GET | Web search with web results, videos, news, infoboxes, discussions |
| `/images/search` | GET | Image search |
| `/videos/search` | GET | Video search |
| `/news/search` | GET | News search |
| `/suggest/search` | GET | Autocomplete suggestions |
| `/summarizer/search` | GET | AI-powered summaries (requires key from web search) |
