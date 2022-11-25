public class MenuItems
{

    public MenuItems()
    {        

    }

    public MenuItems
    (string itemNumber, string itemName, string ingredientList, string price, MenuType menuType)

    {
        ItemNumber = itemNumber;
        ItemName = itemName;
        IngredientList = ingredientList;

    }
 public int ItemNumber {get; set;}
 public string ItemName {get; set;}
 public string IngredientList {get; set;}
 public string Description {get; set;}
 public int price {get; set;}

public string Order
{
    get
    {
        return $"{ItemNumber}{ItemName}{Price}";
    }
}

 public MenuType MenuType {get; set;}

















}