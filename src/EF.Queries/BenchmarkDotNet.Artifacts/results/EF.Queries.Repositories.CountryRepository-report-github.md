```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.4780/22H2/2022Update)
Intel Core i7-9750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.400
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=DefaultJob  

```
| Method              | Mean       | Error    | Median     | Gen0    | Allocated |
|-------------------- |-----------:|---------:|-----------:|--------:|----------:|
| GetCountries        |   998.7 μs | 26.15 μs |   968.8 μs |  7.8125 |  54.88 KB |
| GetColumnsCountries | 1,189.2 μs | 57.00 μs | 1,145.6 μs | 11.7188 |  72.59 KB |
