public class Customer
{

    private string name;
    private Address address;

    public Customer(string name, Address address)
    {

        this.name = name;
        this.address = address;

    }

    public bool InUSA()
    {

        return address.InUSA();

    }

    public override string ToString()
    {

        return $"Name: {name}\nAddress: {address.GetAddress()}";

    }
}