using BenchmarkDotNet.Running;

BenchmarkRunner.Run<StringConcatBenchmark>();
BenchmarkRunner.Run<StringComparisonBenchmark>();