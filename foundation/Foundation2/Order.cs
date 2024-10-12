using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalPrice()
    {
        decimal totalPrice = GetPrice();
        decimal shippingCost = GetShippingCost();
        return totalPrice + shippingCost;
    }

    public decimal GetPrice()
    {
        return _products.Sum(p => p.GetTotalCost());
    }

    public int GetShippingCost()
    {
        return _customer.LivesInUSA() ? 5 : 35;
    }

    public string GetPackingLabel()
    {
        return string.Join("\n", _products.Select(p => $"{p.GetName()} (ID: {p.GetProductId()})"));
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}