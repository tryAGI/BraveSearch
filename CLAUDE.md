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

API key auth (sent as `X-Subscription-Token` header via `--security-scheme`):

```csharp
var client = new BraveSearchClient(apiKey); // BRAVESEARCH_API_KEY env var
```

## Key Files

- `src/libs/BraveSearch/openapi.yaml` -- **Manually maintained** OpenAPI spec (no public spec from Brave)
- `src/libs/BraveSearch/generate.sh` -- Runs autosdk with `--security-scheme ApiKey:Header:X-Subscription-Token` (no download step)
- `src/libs/BraveSearch/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/BraveSearch/Extensions/BraveSearchClient.AsTool.cs` -- MEAI AIFunction tools (AsSearchTool, AsNewsTool)
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

- **No public OpenAPI spec exists** -- `openapi.yaml` was manually created from Brave Search API docs
- All 6 endpoints are GET requests to `https://api.search.brave.com/res/v1`
- Auth: `--security-scheme ApiKey:Header:X-Subscription-Token` sends the key directly as the native header (no spec conversion or PrepareRequest hook needed)

## Endpoints

| Endpoint | Method | Description |
|----------|--------|-------------|
| `/web/search` | GET | Web search with web results, videos, news, infoboxes, discussions |
| `/images/search` | GET | Image search |
| `/videos/search` | GET | Video search |
| `/news/search` | GET | News search |
| `/suggest/search` | GET | Autocomplete suggestions |
| `/summarizer/search` | GET | AI-powered summaries (requires key from web search) |
