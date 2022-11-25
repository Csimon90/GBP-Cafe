public class NewBaseType
{
    public string IngredientList { get; set; }
}

public class MenuItems : NewBaseType
{

    public MenuItems()
    {        

    }

    public MenuItems
    (int itemNumber, string itemName, string ingredientList, string price, MenuItems menuItems)

    {
        ItemNumber = itemNumber;
        ItemName = itemName;
        IngredientList = ingredientList;
        price = price;

    }
        public MenuItems(int itemNumber, string description, int price,  MenuItems menuItems) 
        {
            this.ItemNumber = itemNumber;
            this.Description = description;
            this.price = price;   
        }
        public int ItemNumber {get; set;}
public string ItemName {get; set;}
public string Description {get; set;}
public int price {get; set;}

public string Order
{
    get
    {
        return $"{ItemNumber}{ItemName}{price}";
    }
}

public MenuItems menuItems {get; set;}

















}