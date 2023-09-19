
using BenchmarkDotNet.Running;
using DotNet8Performance.Benchmarks;

Console.WriteLine(BenchmarkRunner.Run<ParallelForEachAndFor>());
