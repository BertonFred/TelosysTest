# Telosys templates for C# web MVC application

This bundle of templates is designed to generate a C# web MVC application with Telosys.

It provides a set of templates to generate Controllers, Models and Views.

## Requirements

- Microsoft SQL Server.
- A Web Application MVC Visual Studio project with EntityFramework installed (via nuget).

## Usage

1. Define all your domain entities in a model

2. Use Telosys to download and install this bundle of templates

3. Define the `NAMESPACE` project variable  
In `telosys-tools.cfg` file : set `ProjectVariable.NAMESPACE`  
Example :`ProjectVariable.NAMESPACE=project`  
( if the project variable is not defined a default name will be used )

4. Define the source folder (where to generate the source code)  
In `telosys-tools.cfg` file : set `SRC`  

5. Generate the code with Telosys.  


## Credits

- Bundle initially created by [Romuald Tuffreau] (https://github.com/romwaldtff).

## Thanks

- [Laurent Guerin](https://github.com/l-gu), creator of [Telosys code generator](http://www.telosys.org/).

## License

This bundle is free and Open Source
[LGPL v3 License](https://www.gnu.org/licenses/lgpl-3.0.en.html) (See the LICENSE file in this repository).

