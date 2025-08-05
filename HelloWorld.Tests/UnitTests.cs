namespace HelloWorld.Tests;

public class Tests
{
    [Test]
    public void GreetingTest()
    {
        Assert.That(HelloWorld.greet(), Is.EqualTo("Hello, World!"));
    }
}
