using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;

namespace DotNet8Performance.Benchmarks;

[Config(typeof(Config))]
[HideColumns(Column.RatioSD, Column.AllocRatio)]
[MemoryDiagnoser(false)]
public class ParallelForEachAndFor
{
    private class Config : ManualConfig
    {
        public Config()
        {
            SummaryStyle = SummaryStyle.Default.WithRatioStyle(RatioStyle.Trend);
        }
    }

    [Benchmark(Baseline = true)]
    public Task ForEachAsync() =>
        Parallel.ForEachAsync(Enumerable.Range(0, 1_000_000), (i, ct) => ValueTask.CompletedTask);

    [Benchmark]
    public Task ForAsync() =>
        Parallel.ForAsync(0, 1_000_000, (i, ct) => ValueTask.CompletedTask);

}
