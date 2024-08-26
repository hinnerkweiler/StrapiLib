using System.Text.Json.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;

namespace StrapiElements;

/// <summary>
/// The Strapi meta Data Element
/// </summary>
public partial class StrapiMeta : ObservableObject
{
    [JsonPropertyName("pagination")] 
    [ObservableProperty]
    private StrapiMetaPagination _pagination;
}

