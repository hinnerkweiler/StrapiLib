using System.Text;
using System.Text.Json.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.AspNetCore.Components;

namespace LenzLib.Model;

/// <summary>
/// A single content block from the Strapi CMS for the Lenzpumpe Website
/// </summary>
public partial class StrapiContentBlock : ObservableObject
{
    [JsonPropertyName("id")]
    [ObservableProperty]
    public int _id;

    [JsonPropertyName("createdAt")]
    [ObservableProperty]
    public DateTime _createdAt;

    [JsonPropertyName("updatedAt")] 
    [ObservableProperty]
    public DateTime _updatedAt;

    [JsonPropertyName("publishedAt")] [ObservableProperty]
    public DateTime? publishedAt;
    
    [JsonPropertyName("locale")] 
    [ObservableProperty]
    public string _locale  = "de-DE";

    public List<StrapiBodyContent> Content { get; set; }

/// <summary>
/// returns the content as a MarkupString for use in Blazor Components
/// </summary>
/// <returns></returns>
    public MarkupString ContentAsHtml()
    {
        var sb = new StringBuilder();
        foreach (var content in Content)
        {
            sb.Append(content.AsHtml());
        }
        return new MarkupString(sb.ToString());
    }
}