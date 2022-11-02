using System.Collections.Generic;
using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        var arr = new List<int>() { -2, 2, 4 };

        var expected = 2;
        var actual = Result.minimumAbsoluteDifference(arr);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var arr = new List<int>() { 3, -7, 0 };

        var expected = 3;
        var actual = Result.minimumAbsoluteDifference(arr);

        Assert.Equal(expected, actual);
    }
}