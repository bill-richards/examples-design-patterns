
if (args.Length > 0)
{
    foreach (var arg in args)
    {
        switch (arg)
        {
            case "iterator":
                gsdc.examples.design_patterns.iterator_implementation.Example.Run();
                break;
            case ".net-iterator":
                gsdc.examples.design_patterns.dotnet_iterator.Example.Run();
                break;
            case "pattern-match":
                gsdc.examples.design_patterns.pattern_matching.Example.Run();
                break;
            case "multiple-patterns":
                gsdc.examples.design_patterns.sorting.Example.Run();
                break;
            case "di":
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
