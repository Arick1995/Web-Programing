~~~~C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// a 的摘要描述
/// </summary>
interface A
{
    string x(string i);

    string y();
}

public class B : A
{
    public string x(string i)
    {
        return i;
    }

    public string y()
    {
        return "AAA";
    }
}
~~~~~~~
