class Program
{
    static void Main(string[] args)
    {
        // Create customer and address
        Address address1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        // Create products
        Product product1 = new Product("Laptop", "A123", 800, 1);
        Product product2 = new Product("Mouse", "B456", 20, 2);

        // Create order and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
    }
}
