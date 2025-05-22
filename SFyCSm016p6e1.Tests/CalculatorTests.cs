using SFyCSm016p6e1;

namespace SFyCSm016p6e1.Tests;

/// <summary>
/// ����� ������ <see cref="Calculator"/>.
/// ��������� ������������ ���������� �������������� ��������.
/// </summary>
public class CalculatorTests
{
    private Calculator calculator;

    /// <summary>
    /// �������������� ��������� ������������ ������.
    /// </summary>
    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    /// <summary>
    /// ���������, ��� ����� <see cref="Calculator.Add(int, int)"/> ��������� ��������� ��������.
    /// </summary>
    [Test]
    public void AddMustReturnCorrectValue()
    {
        var result = calculator.Add(200, 10);

        Assert.That(result == 210);
    }

    /// <summary>
    /// ���������, ��� ����� <see cref="Calculator.Subtract(int, int)"/> ��������� ��������� ��������.
    /// </summary>
    [Test]
    public void SubtractlMustReturnCorrectValue()
    {
        var result = calculator.Subtract(200, 10);

        Assert.That(result == 190);
    }

    /// <summary>
    /// ���������, ��� ����� <see cref="Calculator.Multiply(int, int)"/> ��������� ��������� ��������.
    /// </summary>
    [Test]
    public void MultiplyMustReturnCorrectValue()
    {
        var result = calculator.Multiply(200, 10);

        Assert.That(result == 2000);
    }

    /// <summary>
    /// ���������, ��� ����� <see cref="Calculator.Divide(int, int)"/> ��������� ��������� ��������.
    /// </summary>
    [Test]
    public void DivideMustReturnCorrectValue()
    {
        var result = calculator.Divide(200, 10);

        Assert.That(result == 20);
    }

    /// <summary>
    /// ���������, ��� ����� <see cref="Calculator.Divide(int, int)"/> ���� �������� ����� ����
    ///     ����������� ���������� <see cref="DivideByZeroException"/> 
    /// </summary>
    [Test]
    public void DivideMustThrowException()
    {
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(30, 0));
    }
}