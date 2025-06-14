class Order {
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer) {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product) {
        products.Add(product);
    }

    public double GetTotalPrice() {
        double totalCost = 0;
        foreach (Product product in products) {
            totalCost += product.GetTotalCost();
        }
        totalCost += customer.LivesInUSA() ? 5 : 35;
        return totalCost;
    }

    public string GetPackingLabel() {
        string label = "Packing Label:\n";
        foreach (Product product in products) {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel() {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}
