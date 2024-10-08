# Strapi Elements Project

## Overview

This project provides a set of C# classes to interact with and represent data from the Strapi CMS. The classes are designed to be used in .NET applications and leverage the CommunityToolkit.Mvvm library for observable properties. The project uses the new **Rich Text (Blocks)** field type with nested elements over multiple levels.

## Status

This project is derived from a private project and needs some more features and documentation. It is in early stages of development for a public release and should be considered not ready for production. However, base classes are implemented and tested.

## Structure

### Meta Data
#### StrapiMeta.cs: 
Represents the metadata for Strapi elements, relevant for including pagination.
##### StrapiMetaPagination.cs:
Represents pagination information for Strapi metadata.


### Media Elements
#### StrapiImage.cs: 
Represents an image element in Strapi, including properties like name, URL, dimensions, and more.
##### StrapiImageFormat.cs:
An image in Strapi may be available in several formats.
###### StrapiImageFormatDetail.cs:
Represents the details for each specific image format.

### Content Elements
#### StrapiBodyContent.cs: 
Represents a content block from Strapi, which can include various types of content such as paragraphs, images, lists, etc.
##### StrapiContentChild.cs: 
Represents a child content block within a `StrapiBodyContent`. This is e.g. a paragraph, a headline, a list item, etc.
#### StrapiContentElement.cs: 
The acrual Content of the Child Represents a content element in Strapi.
#### StrapiContentBlock.cs: 
Represents a single content block from the Strapi CMS.


## Dependencies

- .NET 8.0 or later (should work from 6.0 onwards but never tried below 8.0)
- CommunityToolkit.Mvvm (for observable properties)
- Microsoft.AspNetCore.Components (for a simple direct HTML rendering)

## Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/hinnerkweiler/strapi-elements.git
    ```
2. Navigate to the project directory:
    ```sh
    cd strapi-elements
    ```
3. Restore the dependencies:
    ```sh
    dotnet restore
    ```

## Usage

Use these classes as a base to build the elements defined in your Strapi CMS.

### StrapiMeta

The `StrapiMeta` class represents metadata for Strapi elements, including pagination.

```csharp
var meta = new StrapiMeta
{
    Pagination = new StrapiMetaPagination
    {
        Page = 1,
        PageSize = 10,
        PageCount = 5,
        Total = 50
    }
};
```

### StrapiImage

The `StrapiImage` class represents an image element in Strapi.

```csharp
var image = new StrapiImage
{
    Name = "example.jpg",
    Url = "https://example.com/example.jpg",
    Width = 800,
    Height = 600
};
```

### StrapiBodyContent

The `StrapiBodyContent` class represents a content block from Strapi.

```csharp
var content = new StrapiBodyContent
{
    Type = "paragraph",
    Children = new List<StrapiContentChild>
    {
        new StrapiContentChild { Text = "This is a paragraph." }
    }
};
```

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any changes.

## License

This project is licensed under the MIT License. See the `LICENSE` file for more details.