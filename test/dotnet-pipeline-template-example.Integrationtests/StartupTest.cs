using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace dotnet_pipeline_template_example.Integrationtests;

public class StartupTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}