﻿using System.Drawing;
using Hometask1;

namespace Hometask3.Classes;

public class Storage
{
    private readonly List<Product> _products;

    public void Add(Product product) => _products.Add(product);

    private void ConsoleInit()
    {
        var temp = new List<Product> { new Product(), new Meat(), new DairyProduct() };

        foreach (var item in temp)
        {
            item.ConsoleInput();
        }
    }

    public void Output()
    {
        foreach (var item in _products)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public void ChangePriceByPercentage(decimal percents)
    {
        foreach (var item in _products)
        {
            item.Price += item.Price * 100 / percents;
        }
    }

    public List<Product> GetAllMeatProducts() => _products.Where(t => t.GetType() == typeof(Meat)).ToList();

    public Product? this[int index]
    {
        get
        {
            if (index >= 0 && index < _products.Count) return _products[index];
            Console.WriteLine("Index out of range");
            return null;
        }

        set
        {
            if (index < 0 || index >= _products.Count)
            {
                Console.WriteLine("Index out of range");
                return;
            }

            if (value is null)
            {
                Console.WriteLine("Value is null");
                return;
            }

            _products[index] = value;
        }
    }

    public Storage(params Product[] products) => _products = new List<Product>(products);
}