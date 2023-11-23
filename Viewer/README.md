[« back](../README.md#do-you-need-to-know-how-to-implement-design-patterns) | [next](../Benchmarks/README.md) | [solution](./)
# Examples Runner
This project enables you to run all of the example projects from a single location. You can run all examples by omitting any options; you can run a single example by specifying a single option; or you can run multiple examples by specifying multiple options.

### Building the project
#### From the solution root directory
> dotnet build Viewer -c Release|Debug
#### From the Viewer project directory
> dotnet build -c Release|Debug
### Usage
#### From the solution root directory
> dotnet .\Viewer\bin\Release\net7.0\Viewer.dll [option [option [option [...]]]]
#### From the Viewer project directory
> dotnet .\bin\Release\net7.0\Viewer.dll [option [option [option [...]]]]
#### Example
> dotnet .\Viewer\bin\Release\net7.0\Viewer.dll iterator pattern-match .net-iterator
#### Options
- iterator

  Run the home-baked [Iterator](../IteratorImplementation/README.md) example project
- .net-iterator

  Run the [.net Iterator](../DotNetIterator/README.md) example project
- pattern-match

  Run the [Pattern Matching](../PatternMatching/README.md) example project
- multiple-patterns

  Run the project which demonstrates the inclusion of [multiple patterns](../Sorting/README.md)
