using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FibonacciSequence : MonoBehaviour
{
    [SerializeField] private int number = 10;

    static int numberOfRecursions = 0;
    // Start is called before the first frame update
    void Start()
    {
        long fibonacciNumber = CalculateFibonacciSequence(number);
        Debug.Log($"The {number}th number is {fibonacciNumber}");
    }


    static long CalculateFibonacciSequence(int n)
    {
        Dictionary<int, long> sequence = new Dictionary<int, long>();
         return Fibonacci(n, sequence);
    }

    static long Fibonacci(int n, Dictionary<int, long> cache)
    {
        numberOfRecursions++;
        if (cache.ContainsKey(n))
        {
            Debug.Log("Used this cache");
            return cache[n];
        }

        long fibNumber;
        if (n <= 1)
        {
            fibNumber = n;
        }
        else
        {
            Debug.Log($"About to call itself again with {numberOfRecursions}");
            fibNumber = Fibonacci(n-1, cache) + Fibonacci(n-2, cache);
        }

        cache[n] = fibNumber;

        return fibNumber;
    }
}
