using BenchmarkDotNet.Running;
using EF.Queries.Repositories;

namespace EF.Queries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<CountryRepository>();
        }

    }
}
