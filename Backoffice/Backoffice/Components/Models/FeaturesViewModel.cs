namespace Backoffice.Components.Models;

public class FeaturesViewModel
{
    public string Id { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Text { get; set; } = null!;
    public List<FeatureViewModel> Features { get; set; } = null!;
}