using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathsqrBench : BenchmarkBase
{

    private float value;
    protected override void Init()
    {
        MaxRecommendedIterations = 3000;
        BenchmarkName = "mathsqrt";
        Benchmarks.Add(new BenchmarkData("calculate mathsqrt", () =>
        {
            value += Mathf.Sqrt(1000);

        }));
    }
}
