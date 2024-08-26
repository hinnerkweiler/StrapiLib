namespace StrapiElements;

public class StrapiImage
{
    /// <summary>
    /// A Strapi image Element.
    /// </summary>
    public string name { get; set; }
    public string alternativeText { get; set; }
    public string url { get; set; }
    public string caption { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public StrapiImageFormats formats { get; set; }
    public string hash { get; set; }
    public string ext { get; set; }
    public string mime { get; set; }
    public double size { get; set; }
    public string previewUrl { get; set; }
    public string provider { get; set; }
    public object provider_metadata { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
}
