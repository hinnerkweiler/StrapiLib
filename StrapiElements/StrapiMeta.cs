using System.Text.Json.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;

namespace LenzLib.Model;

/// <summary>
/// The Strapi meta Data
/// </summary>
public partial class StrapiMeta : ObservableObject
{
    [JsonPropertyName("pagination")] 
    [ObservableProperty]
    private StrapiMetaPagination _pagination;
}

