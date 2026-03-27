/*
order: 30
title: MEAI Search Tool
slug: meai-search-tool

Example showing how to use BraveSearch as an AIFunction tool with any IChatClient.
*/

namespace BraveSearch.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_AsSearchTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create an AIFunction tool from BraveSearch for use with any IChatClient
        var searchTool = client.AsSearchTool(count: 3);

        searchTool.Name.Should().Be("BraveWebSearch");
        searchTool.Description.Should().Contain("Brave Search");
    }
}
