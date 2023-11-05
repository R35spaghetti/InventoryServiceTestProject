namespace InventoryService;

public class InventoryService
{
    private List<Product?> Products = new List<Product?>();

    public Product? GetStockStatus(int id)
    {
        foreach (var item in Products)
        {
            if (item?.Id == id)
            {
                return item;
            }
        }

        return null;
    }

    public Product? UpdateStockStatus(int id, int numberOfItems)
    {
        foreach (var item in Products)
        {
            if (item?.Id == id)
            {
                item.Amount = numberOfItems;

                return item;
            }
        }

        return null;
    }


    public bool IsLowInStock(int id)
    {
        foreach (var item in Products)
        {
            if (item?.Id == id)
            {
                if (item.Amount <= 5)
                {
                    return true;
                }
            }
        }

        return false;
    }
}