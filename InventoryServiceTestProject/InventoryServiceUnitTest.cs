using InventoryServiceTestProject.Sut;
using Xunit.Abstractions;

namespace InventoryServiceTestProject;

public class InventoryServiceUnitTest
{
    private readonly InventoryService _sut = new InventoryService();
    private readonly ITestOutputHelper _testOutputHelper;


    public InventoryServiceUnitTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }
    
    [Fact]
    public void Should_Return_Correct_Stock_Status()
    {
        bool works = false;
        var currentProduct = _sut.GetStockStatus(1);

        if (currentProduct != null)
        {
            works = true;
        }
        
        _testOutputHelper.WriteLine($"Product: {currentProduct.Name} \n Amount: {currentProduct.Amount}");
        Assert.True(works);
    }
    
    [Fact]
    public void Should_Return_Correct_Stock_Status_After_Update()
    {
        int newStockValue = 7;

        var oldProduct = _sut.GetStockStatus(1);
        Assert.NotEqual(newStockValue,oldProduct.Amount);

        var updatedProduct = _sut.UpdateStockStatus(1, newStockValue);

        Assert.Equal(oldProduct.Amount,updatedProduct.Amount);
    }
    
    
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void True_If_Supply_Is_High_False_If_Supply_Is_Low(int id)
    {
        var product = _sut.IsLowInStock(id);
        if (product)
        {
            _testOutputHelper.WriteLine("true");
            Assert.True(product);
        }
        else
        {
            _testOutputHelper.WriteLine("false");
            Assert.False(product);
        }
    }
}