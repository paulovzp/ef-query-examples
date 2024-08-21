using BenchmarkDotNet.Running;
using EF.Queries.Entities;
using EF.Queries.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

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
