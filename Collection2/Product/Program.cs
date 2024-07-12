using Product;

public class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
        inventory.AddProduct("Book", 10);
        inventory.AddProduct("Pencil", 30);
        inventory.GetQuantityByProduct("Book");
        inventory.GetQuantityByProduct("Pencil");
        inventory.GetQuantityByProduct("notebook"); 
        inventory.UpdateQuantity("Book", 20);
        inventory.UpdateQuantity("Pencil", 40);
        inventory.GetQuantityByProduct("Book");
        inventory.GetQuantityByProduct("Pencil");
        inventory.RemoveProduct("Book");
        inventory.GetQuantityByProduct("Book");
    }
}
