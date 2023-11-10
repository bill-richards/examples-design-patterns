using System.Diagnostics;

if (Debugger.IsAttached)
    Runner.Run();
else
    Runner.Benchmark();