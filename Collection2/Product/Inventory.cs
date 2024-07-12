
namespace Product
{
    internal class Inventory
    {
        Dictionary<string, int> Products = new Dictionary<string, int>();
        public void AddProduct(string name, int quantity)
        {
            Products.Add(name, quantity);
        }
        public void RemoveProduct(string name)
        {
            Products.Remove(name);
        }
        public void UpdateQuantity(string name, int quantity)
        {
            Products[name] = quantity;
        }
        public void GetQuantityByProduct(string name)
        {
            if (Products.ContainsKey(name))
            {
                Console.WriteLine($"{name} have : " + Products[name]);
            }
            else
            {
                Console.WriteLine("This product does not exist");
            }
        }
    }

 
}
