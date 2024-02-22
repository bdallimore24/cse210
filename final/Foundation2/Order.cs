using System.Collections.Generic;

public class Order
{

    private List<Product> products;
    private Customer customer;


    public Order(List<Product> products, Customer customer)
    {

        this.products = products;
        this.customer = customer;

    }


    public double GetTotalCost()
    {

        double total = 0;

        foreach (Product product in products)
        {

            total += product.GetPrice();

        }

        total += customer.InUSA() ? 5 : 35;
        return total;

    }

    public string GetPackingLabel()
    {
        
        string label = "\n*******************\n\nPacking label:\n";

        foreach (Product product in products)
        {

            label += $"{product}\n";

        }

        return label;

    }


    public string GetShippingLabel()
    {
        
        return $"*******************\n\nShipping label:\n{customer}";

    }
}