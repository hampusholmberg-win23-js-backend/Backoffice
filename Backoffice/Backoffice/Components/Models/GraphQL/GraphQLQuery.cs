namespace Backoffice.Components.Models.GraphQL;

public class GraphQLQuery
{
    public string Query { get; set; } = null!;
    public Variables? Variables { get; set; }
}

public class Variables
{
    public int Id { get; set; }
}