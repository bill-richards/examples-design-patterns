
if (args.Length > 0)
{
    foreach (var arg in args)
    {
        switch (arg)
        {
            case "impl":
            case "Impl":
            case "Implementation":
            case "implementation":
                gsdc.examples.design_patterns.iterator_implementation.Example.Run();
                break;
            case "Dotnet":
            case "dotnet":
            case "dotNet":
            case "DotNet":
                gsdc.examples.design_patterns.dotnet_iterator.Example.Run();
                break;
            case "pattern":
            case "Pattern":
            case "Pattern-Matching":
            case "Pattern-matching":
            case "pattern-matching":
            case "pattern-Matching":
                gsdc.examples.design_patterns.pattern_matching.Example.Run();
                break;
            case "sort":
            case "Sort":
            case "sorting":
            case "Sorting":
                gsdc.examples.design_patterns.sorting.Example.Run();
                break;
            case "di":
            case "Di":
            case "DI":
                gsdc.examples.design_patterns.dependency_injection.Example.Run();
                break;
        }
    }

    return;
}


gsdc.examples.design_patterns.iterator_implementation.Example.Run();
gsdc.examples.design_patterns.dotnet_iterator.Example.Run();
gsdc.examples.design_patterns.pattern_matching.Example.Run();
gsdc.examples.design_patterns.sorting.Example.Run();
gsdc.examples.design_patterns.dependency_injection.Example.Run();
