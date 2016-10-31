using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class SampleTest
{
    [Test]
    public void SumTest()
    {
        int x = 1;
        int y = 2;

        int sum = x + y;

        Assert.AreEqual(sum, 3);
    }
}
