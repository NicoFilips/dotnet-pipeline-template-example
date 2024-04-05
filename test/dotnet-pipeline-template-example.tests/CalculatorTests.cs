using dotnet_pipeline_template_example.core;
using FluentAssertions;

namespace dotnet_pipeline_template_example.tests;

public class CalculatorTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Add_whenResultisCorrect_returnTrue()
    {
        // Arrange
        var calculator = new Calculator();
        var a = 1;
        var b = 2;

        // Act
        var result = calculator.Add(a, b);

        // Assert
        result.Should().Be(3);
    }
    
    [Test]
    public void Subtract_whenResultisCorrect_returnTrue()
    {
        // Arrange
        var calculator = new Calculator();
        var a = 1;
        var b = 2;

        // Act
        var result = calculator.Subtract(a, b);

        // Assert
        result.Should().Be(-1);
    }
    
    [Test]
    public void Multiply_whenResultisCorrect_returnTrue()
    {
        // Arrange
        var calculator = new Calculator();
        var a = 1;
        var b = 2;

        // Act
        var result = calculator.Multiply(a, b);

        // Assert
        result.Should().Be(2);
    }
    
    [Test]
    public void Divide_whenResultisCorrect_returnTrue()
    {
        // Arrange
        var calculator = new Calculator();
        var a = 4;
        var b = 2;

        // Act
        var result = calculator.Divide(a, b);

        // Assert
        result.Should().Be(2);
    }
}