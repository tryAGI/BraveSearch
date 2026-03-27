# Authentication

The Brave Search API uses an API key for authentication, passed via the `X-Subscription-Token` header.

## Getting an API Key

1. Sign up at [brave.com/search/api](https://brave.com/search/api/)
2. Navigate to the API keys section in your dashboard
3. Create a new API key

## Client Initialization

```csharp
using BraveSearch;

var client = new BraveSearchClient(
    apiKey: Environment.GetEnvironmentVariable("BRAVESEARCH_API_KEY")!);
```

The SDK handles the authentication header conversion automatically.
Internally, the client converts the standard Bearer token to the
`X-Subscription-Token` header that Brave Search expects.

## Environment Variables

For integration tests, set the following environment variable:

```bash
export BRAVESEARCH_API_KEY=your-api-key-here
```
