namespace InventoryServiceTestProject.Sut;

public class InventoryService
{
    List<Product?> Products = new List<Product?>
    {
        new Product(1, 5, "Oegas"),
        new Product(2, 10, "Wooqvist"),
        new Product(3, 2, "Lövbergs")
    };

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