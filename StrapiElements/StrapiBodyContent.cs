using System.Text;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Components;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Primitives;

namespace StrapiElements;

/// <summary>
/// The StrapiBodyContent class is a single content block from the Strapi CMS that contains a list of children (StrapiContentChild) e.g. paragraphs, images, etc. 
/// </summary>
public partial class StrapiBodyContent : ObservableObject
{
    [JsonPropertyName("type")]
    [ObservableProperty] private string _type;

    [JsonPropertyName("type")]
    [ObservableProperty] private List<StrapiContentChild> _children;
    
    [JsonPropertyName("type")]
    [ObservableProperty] private int? _level;

    [JsonPropertyName("type")]
    [ObservableProperty] private string? _format;
    
    [JsonPropertyName("type")]
    [ObservableProperty] private StrapiImage? _image;
    

    /// <summary>
    /// Returns the type of the content block e.g. paragraph, list-item, link, etc. in html
    /// </summary>
    /// <param name="isInner"></param>
    /// <returns></returns>
    public MarkupString AsHtml(bool isInner = false)
    {
        var sb = new StringBuilder();
        switch (Type) 
        {
            case "paragraph":
                sb.Append("<p>");
                break;
            case "list" :
                if(Format == "unordered")
                {
                    sb.Append("<ul>");
                }
                else 
                {
                    sb.Append("<ol>");
                }
                break;
            case "heading":
                sb.Append($"<h{Level}>");
                break;
            case "quote":
                sb.Append($"<blockquote>");
                break;
            case "code":
                sb.Append($"<code>");
                break;
        }
        foreach (var child in Children)
        {
            switch (Type)
            {
                case "image":
                    sb.Append($"<img src='{Image.url}' alt='{Image.alternativeText}' />");
                    break;
                default:
                    sb.Append($"{child.AsHtml()}");
                    break;
            }
        }
        switch (Type) 
        {
            case "paragraph":
                sb.Append("</p>");
                break;
            case "list" :
                if(Format == "unordered")
                {
                    sb.Append("</ul>");
                }
                else 
                {
                    sb.Append("</ol>");
                }
                break;
            case "heading":
                sb.Append($"</h{Level}>");
                break;
            case "quote":
                sb.Append($"</blockquote>");
                break;
            case "code":
                sb.Append($"</code>");
                break;
        }

        return new MarkupString(sb.ToString());
    }
    
    
}