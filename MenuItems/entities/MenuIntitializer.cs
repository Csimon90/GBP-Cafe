public class MenuInitializer
{
    static void Main() {Console.WriteLine("one day ill learn to type"); }
    public MenuInitializer
    (int itemNumber, string itemName, string ingredientList, int price, MenuItems menuItems)

    {
        ItemNumber = itemNumber;
        ItemName = itemName;
        Description = ingredientList;
        Price = price;
        MenuItems = menuItems;
    }

    public int ItemNumber { get; set; }
    public string ItemName { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }

    public string Order
    {
        get
        {
            return $"{ItemNumber}{ItemName}{Price}";
        }
    }

    public MenuItems MenuItems { get; set; }



}