namespace Backoffice.Components.Models.GraphQL;

public class GraphQLMutation
{
    public string query { get; set; } = null!;
    public Variables? variables { get; set; }
}