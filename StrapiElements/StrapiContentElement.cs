using System.Text;
using System.Text.Json.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.AspNetCore.Components;

namespace LenzLib.Model;

/// <summary>
/// A Strapi content element.
/// </summary>
public partial class StrapiContentElement : ObservableObject
{
    [JsonPropertyName("data")] 
    [ObservableProperty]
    public StrapiContentBlock _data;
}