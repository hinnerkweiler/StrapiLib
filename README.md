# Strapi Elements Project

## Overview

This project provides a set of C# classes to interact with and represent data from the Strapi CMS. The classes are designed to be used in .NET applications and leverage the CommunityToolkit.Mvvm library for observable properties.
Uses the new **Rich Text (Blocks)** field type with nested elements over multiple levels.

## Status
This project is derived from a private project and needs some more features and documentation. It is in early stages of development for a public release and should be considered not ready for production. 
However, base classes are implemented and tested. 

## Dependencies

- .NET 8.0 or later (should work from 6.0 onwards but never tried below 8.0...)
- CommunityToolkit.Mvvm *(for observable properties)*
- Microsoft.AspNetCore.Components *(for a simple direct HTML rendering)*

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

Use this class a base to build the Elements defined in your Strapi CMS.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request.

## License

This project is licensed under the MIT License. See the `LICENSE` file for more details.