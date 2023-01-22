using SimpleAPI.Controllers;

namespace SimpleAPI.Tests;

public class UnitTest1
{
    ValuesController controller = new ValuesController();
    [Fact]
    public void Test1()
    {
         var returnValue = controller.Get(1);
  Assert.Equal("Sachin", returnValue);
    }
}