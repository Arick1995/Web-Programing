using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Item 的摘要描述
/// </summary>
public class Item
{
    public Item()
    {
        //
        // TODO: 在這裡新增建構函式邏輯
        //
    }
    public string Name
    {
        get;
        set;
    }

    public string ID
    {
        get;
        set;
    }
    public string GetFullName()
    {
        return ID + "_" + Name;
    }
}
