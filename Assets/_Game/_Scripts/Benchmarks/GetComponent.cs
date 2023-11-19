using System.Collections;
using UnityEngine;

namespace Assets._Game._Scripts.Benchmarks
{
    public class GetComponent : BenchmarkBase
    {
        [SerializeField] private AudioSource AudioSource;
        protected override void Init()
        {
            BenchmarkName = "GetComponent";
            Benchmarks.Add(new BenchmarkData("Get Component", () =>
            {
                AudioSource = GetComponent<AudioSource>();
                print(AudioSource);
            }));

            Benchmarks.Add(new BenchmarkData("use reference", () =>
            {
                print(AudioSource);
            }));
        }
    }
}