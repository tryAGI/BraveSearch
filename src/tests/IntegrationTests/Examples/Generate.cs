/*
order: 10
title: Web Search
slug: web-search

Basic example showing how to perform a web search with Brave Search.
*/

namespace BraveSearch.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_WebSearch()
    {
        using var client = GetAuthenticatedClient();

        //// Perform a web search
        var response = await client.WebSearchAsync(
            q: "Brave Search API");

        response.Web.Should().NotBeNull();
        response.Web!.Results.Should().NotBeNull();
        response.Web.Results!.Count.Should().BeGreaterThan(0);

        var firstResult = response.Web.Results[0];
        firstResult.Title.Should().NotBeNullOrWhiteSpace();
        firstResult.Url.Should().NotBeNullOrWhiteSpace();
    }
}
