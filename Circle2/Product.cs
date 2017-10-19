using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Product 的摘要描述
/// </summary>
public class Product:Item
{
    public Product()
    {
        //
        // TODO: 在這裡新增建構函式邏輯
        //
    }
    public double price
    {
        get;
        set;
    }

    public double Total_Sales(int volmn)
    {
        
        return volmn * price;
    }

}
