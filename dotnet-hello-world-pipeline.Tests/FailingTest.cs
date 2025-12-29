namespace dotnet_hello_world_pipeline.Tests;

public class FailingTest
{
    [Fact]
    public void Output_must_fail()
    {
        Assert.True(false);
    }
}
