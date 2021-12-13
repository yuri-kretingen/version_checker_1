using System;
public class TestApi
{
    public void TestFoo()
    {
        Console.WriteLine("Test Foo");
    }

    public void TestFoo2()
    {
        this.TestFoo();
    }
}