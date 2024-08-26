using System.Text;
using System.Text.Json.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Primitives;

namespace LenzLib.Model;

/// <summary>
/// The StrapiContentChild class is a single content block from the Strapi CMS that contains a list of children (StrapiContentChild) e.g. paragraphs, images, etc.
/// </summary>
public partial class StrapiContentChild : ObservableObject
{
    [JsonPropertyName("type")]
    [ObservableProperty] private string _type;

    [JsonPropertyName("text")]
    [ObservableProperty] private string? _text;

    [JsonPropertyName("bold")]
    [ObservableProperty] private bool? _bold;

    [JsonPropertyName("italic")]
    [ObservableProperty] private bool? _italic;

    [JsonPropertyName("underline")]
    [ObservableProperty] private bool? _underline;

    [JsonPropertyName("strikethrough")]
    [ObservableProperty] private bool? _strikethrough;

    [JsonPropertyName("code")]
    [ObservableProperty] private bool? _code;

    [JsonPropertyName("url")]
    [ObservableProperty] private string? _url;
    
    [JsonPropertyName("children")]
    [ObservableProperty] private List<StrapiContentChild>? _children;
    
    /// <summary>
    /// Returns the type of the content block e.g. paragraph, list-item, link, etc. in html
    /// </summary>
    /// <param name="isInner"></param>
    /// <returns></returns>
    public string AsHtml(bool isInner = false)
    {
        var sb = new StringBuilder();
        
        if (Type == "list-item")
        {
            sb.Append("<li>");
            var ssb = new StringBuilder();
            foreach (var subchild in Children)
            {
                ssb.Append(subchild.AsHtml());
            }
            sb.Append(ssb.ToString());
            sb.Append("</li>");
        }
        
        if (Bold == true)
        {
            sb.Append("<strong>");
        }

        if (Italic == true)
        {
            sb.Append("<em>");
        }
        
        if (Underline == true)
        {
            sb.Append("<u>");
        }
        
        if (Strikethrough == true)
        {
            sb.Append("<s>");
        }
        
        if (Code == true)
        {
            sb.Append("<code>");
        }
        
        if (Type == "link")
        {
            sb.Append($"<a class=\"links\" href={Url ?? "/"}>");
            var ssb = new StringBuilder();
            foreach (var subchild in Children)
            {
                ssb.Append(subchild.AsHtml());
            }
            sb.Append(ssb.ToString());
            sb.Append("</a>");
        }
        
        sb.Append(Text);
        
        if (Code == true)
        {
            sb.Append("</code>");
        }
        if (Strikethrough == true)
        {
            sb.Append("</s>");
        }
        if (Underline == true)
        {
            sb.Append("</u>");
        }
        if (Italic == true)
        {
            sb.Append("</em>");
        }
        if (Bold == true)
        {
            sb.Append("</strong>");
        }
       
        return sb.ToString();
    }
}