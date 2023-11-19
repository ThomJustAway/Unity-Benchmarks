using System.Collections;
using UnityEngine;

namespace Assets._Game._Scripts.Benchmarks.Benchmark_Helpers
{
    public class NonAllocInd : BenchmarkBase
    {
        private const float RADIUS = 10;
        private readonly Collider[] _collisions = new Collider[100];

        protected override void Init()
        {
            MaxRecommendedIterations = 250000;
            BenchmarkName = "NonAllocVersion";

            Benchmarks.Add(new BenchmarkData("OverlapSphereNonAlloc", () => {
                var result = Physics.OverlapSphereNonAlloc(transform.position, RADIUS, _collisions);
            }));
        }
    }
}