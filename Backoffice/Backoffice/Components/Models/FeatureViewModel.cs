namespace Backoffice.Components.Models;

public class FeatureViewModel
{
    public ImageViewModel FeatureImage { get; set; } = new ImageViewModel();
    public string FeatureTitle { get; set; } = null!;
    public string FeatureDescription { get; set; } = null!;
}