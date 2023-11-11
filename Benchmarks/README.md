[« back](../README.md#do-you-need-to-know-how-to-implement-design-patterns) | [solution](./)
# Benchmarks 

## What do they show

To be honest, I'm not entirely sure. It's obvious that they demonstrate the speed of running these routines.

## Running the benchmarks
From the solution root directory
> dotnet build Benchmarks -c Release

> dotnet .\Benchmarks\bin\Release\net7.0\Benchmarks.dll

From the Benchmarks project directory
> dotnet build -c Release

> dotnet .\bin\Release\net7.0\Benchmarks.dll

### Benchmark Results

Interestingly it seems that the hand-cranked Iterator is faster than the .net `IEnumerable<T>`. My understanding is, however, that there will be a significant increase in speed with the updates in .net 8.0, so it will be interesting to see how the results compare whenit is released.

![benchamark results](../images/benchmarks.png)