# .NET 8 Performace 
**In this repository I try to address all performance improvements in .NET 8!**

## Parallel.ForAsync
[Benchmark Code](DotNet8Performace/Benchmarks/ParallelForEachAndFor.cs)

### Result
```bash
| Method       | Mean     | Error   | StdDev  | Ratio        | Allocated  |
|------------- |---------:|--------:|--------:|-------------:|-----------:|
| ForEachAsync | 502.7 ms | 9.08 ms | 9.72 ms |     baseline | 87934728 B |
| ForAsync     | 140.7 ms | 2.72 ms | 3.72 ms | 3.57x faster |      420 B |
```

## AllNonEmpty
[Benchmark Code](DotNet8Performace/Benchmarks/AllNonEmpty.cs)

### Result
```bash
| Method               | Mean      | Error     | StdDev    | Ratio         | Allocated |
|--------------------- |----------:|----------:|----------:|--------------:|----------:|
| AllNonEmpty_Any      | 7.7122 ns | 0.1232 ns | 0.1029 ns |      baseline |      32 B |
| AllNonEmpty_Property | 0.2521 ns | 0.0123 ns | 0.0115 ns | 30.49x faster |         - |
```
