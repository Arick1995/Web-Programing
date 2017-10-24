~~~~C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Class1 的摘要描述
/// </summary>
public class Product
{
    public Product()
    {
        //
        // TODO: 在這裡新增建構函式邏輯
        //
    }
    public double Price
    {
        get;
        set;
    }

    public double Total_Price(double p, int n, double d = 0)
    {
        return (p - p * d / 100) * n;
    }
}
~~~~~
