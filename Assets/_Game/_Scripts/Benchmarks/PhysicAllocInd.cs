using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicAllocInd : BenchmarkBase
{
    private const float RADIUS = 10;
    private readonly Collider[] _collisions = new Collider[100];

    protected override void Init()
    {
        MaxRecommendedIterations = 250000;
        BenchmarkName = "AllocVersion";

        Benchmarks.Add(new BenchmarkData("OverlapSphere", () => {
            var result = Physics.OverlapSphere(transform.position, RADIUS);
        }));
    }

}
