/* order: 40, title: MEAI Tools, slug: meai-tools */

using Microsoft.Extensions.AI;

namespace BraveSearch.IntegrationTests;

public partial class Tests
{
    //// BraveSearch provides AIFunction tools that can be used with any
    //// `Microsoft.Extensions.AI.IChatClient` to give AI agents access to
    //// web search and news search capabilities.

    [TestMethod]
    public async Task Meai_AsSearchTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that searches the web:
        var tool = client.AsSearchTool();

        tool.Name.Should().Be("BraveWebSearch");
        tool.Description.Should().Contain("Brave Search");
    }

    [TestMethod]
    public async Task Meai_AsNewsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that searches for news:
        var tool = client.AsNewsTool();

        tool.Name.Should().Be("BraveNewsSearch");
        tool.Description.Should().Contain("news");
    }
}
