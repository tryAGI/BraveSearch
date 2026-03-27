/*
order: 20
title: News Search
slug: news-search

Example showing how to search for news articles.
*/

namespace BraveSearch.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_NewsSearch()
    {
        using var client = GetAuthenticatedClient();

        //// Search for recent news
        var response = await client.NewsSearchAsync(
            q: "artificial intelligence",
            count: 5);

        response.Results.Should().NotBeNull();
        response.Results!.Count.Should().BeGreaterThan(0);

        var firstResult = response.Results[0];
        firstResult.Title.Should().NotBeNullOrWhiteSpace();
        firstResult.Url.Should().NotBeNullOrWhiteSpace();
    }
}
