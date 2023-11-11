[« back](../README.md#do-you-need-to-know-how-to-implement-design-patterns) | [solution](./)
# Examples Runner / Viewer

Using this project you can run all or any individual example project. To run all do not specify and options, to run each example individually specify it as an option

From the solution root directory
> dotnet build Viewer -c Release|Debug

> dotnet .\Viewer\bin\Release\net7.0\Viewer.dll [ Impl | dotnet | pattern | sort | di ]

From the Viewer project directory
> dotnet build -c Release|Debug

> dotnet .\bin\Release\net7.0\Viewer.dll [ Impl | dotnet | pattern | sort | di ]