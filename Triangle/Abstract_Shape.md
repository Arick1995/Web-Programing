~~~~C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Shape 的摘要描述
/// </summary>
public abstract class Shape
{

    public string Developer()
    {
        return "King of C#";
    }

    public abstract double Area();
}

public class Triangle : Shape
{
    public double Base
    {
        get;
        set;
    }

    public double Height
    {
        get;
        set;
    }

    public override double Area()
    {
        return Base * Height / 2;
    }
}
~~~~~
