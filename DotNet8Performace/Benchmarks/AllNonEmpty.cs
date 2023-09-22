using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;

namespace DotNet8Performance.Benchmarks;

[Config(typeof(Config))]
[HideColumns(Column.RatioSD, Column.AllocRatio)]
[MemoryDiagnoser(false)]
public class AllNonEmpty
{
    private class Config : ManualConfig
    {
        public Config()
        {
            SummaryStyle = SummaryStyle.Default.WithRatioStyle(RatioStyle.Trend);
        }
    }

    private readonly string _str = "hello";
    private readonly List<int> _list = new() { 1, 2, 3 };
    private readonly int[] _array = new int[] { 4, 5, 6 };

    [Benchmark(Baseline = true)]
    public bool AllNonEmpty_Any() =>
        _str.Any() &&
        _list.Any() &&
        _array.Any();

    [Benchmark]
    public bool AllNonEmpty_Property() =>
        _str.Length != 0 &&
        _list.Count != 0 &&
        _array.Length != 0;
}
