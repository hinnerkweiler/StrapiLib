using System.Text.Json.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;

namespace LenzLib.Model;


/// <summary>
/// The Strapi meta pagination.
/// </summary>
public partial class StrapiMetaPagination : ObservableObject
{
    [JsonPropertyName("page")] 
    [ObservableProperty]
    private int _page;

    [JsonPropertyName("pageSize")] 
    [ObservableProperty]
    private int _pageSize;

    [JsonPropertyName("pageCount")] 
    [ObservableProperty]
    private int _pageCount;

    [JsonPropertyName("total")] 
    [ObservableProperty]
    private int _total;
}

