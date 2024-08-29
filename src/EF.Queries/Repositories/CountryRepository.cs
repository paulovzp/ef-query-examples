using BenchmarkDotNet.Attributes;
using EF.Queries.Entities;

namespace EF.Queries.Repositories;

[MemoryDiagnoser]
[HideColumns(BenchmarkDotNet.Columns.Column.Job, BenchmarkDotNet.Columns.Column.RatioSD, BenchmarkDotNet.Columns.Column.StdDev, BenchmarkDotNet.Columns.Column.AllocRatio)]
public class CountryRepository
{
    private readonly EFQQueryContext _context;

    public CountryRepository()
    {
        _context = new EFQQueryContext();
    }

    [Benchmark]
    public List<Country> GetCountries()
    {
        return _context.Set<Country>().ToList();
    }

    [Benchmark]
    public List<Country> GetColumnsCountries()
    {
        return (from country in _context.Set<Country>()
                select new Country
                {
                    Name = country.Name,
                    Id = country.Id
                }).ToList();
    }
}
