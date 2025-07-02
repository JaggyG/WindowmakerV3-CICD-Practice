using Xunit;

namespace TestApi.Tests;

public class FailingTest
{
    [Fact]
    public void This_Test_Will_Fail()
    {
        // Uncomment the line below to see what happens when a test fails
        //Assert.True(false, "This test is designed to fail!");
        
        // For now, let's make it pass
         Assert.True(true);
    }
    
    [Fact]
    public void This_Test_Passes()
    {
        var result = 2 + 2;
        Assert.Equal(4, result);
    }
}