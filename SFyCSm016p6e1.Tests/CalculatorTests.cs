using SFyCSm016p6e1;

namespace SFyCSm016p6e1.Tests;

/// <summary>
/// Тесты класса <see cref="Calculator"/>.
/// Проверяет корректность выполнения арифметических операций.
/// </summary>
public class CalculatorTests
{
    private Calculator calculator;

    /// <summary>
    /// Инициализирует экземпляр тестируемого класса.
    /// </summary>
    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    /// <summary>
    /// Проверяет, что метод <see cref="Calculator.Add(int, int)"/> корректно выполняет операцию.
    /// </summary>
    [Test]
    public void AddMustReturnCorrectValue()
    {
        var result = calculator.Add(200, 10);

        Assert.That(result == 210);
    }

    /// <summary>
    /// Проверяет, что метод <see cref="Calculator.Subtract(int, int)"/> корректно выполняет операцию.
    /// </summary>
    [Test]
    public void SubtractlMustReturnCorrectValue()
    {
        var result = calculator.Subtract(200, 10);

        Assert.That(result == 190);
    }

    /// <summary>
    /// Проверяет, что метод <see cref="Calculator.Multiply(int, int)"/> корректно выполняет операцию.
    /// </summary>
    [Test]
    public void MultiplyMustReturnCorrectValue()
    {
        var result = calculator.Multiply(200, 10);

        Assert.That(result == 2000);
    }

    /// <summary>
    /// Проверяет, что метод <see cref="Calculator.Divide(int, int)"/> корректно выполняет операцию.
    /// </summary>
    [Test]
    public void DivideMustReturnCorrectValue()
    {
        var result = calculator.Divide(200, 10);

        Assert.That(result == 20);
    }

    /// <summary>
    /// Проверяет, что метод <see cref="Calculator.Divide(int, int)"/> если делитель равен нулю
    ///     выбрасывает исключение <see cref="DivideByZeroException"/> 
    /// </summary>
    [Test]
    public void DivideMustThrowException()
    {
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(30, 0));
    }
}