using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFyCSm016p6e1;

/// <summary>
/// Класс-калькулятора для выполнения базовых арифметических операций.
/// </summary>
public class Calculator
{
    /// <summary>
    /// Инициализирует новый экземпляр класса.
    /// </summary>
    public Calculator()
    {
        // Конструктор по умолчанию
    }

    /// <summary>
    /// Выполняет сложение двух чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Результат сложения двух чисел.</returns>
    public int Add(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Выполняет вычитание двух чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Результат вычитания двух чисел.</returns>
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    /// <summary>
    /// Выполняет умножение двух чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Результат умножения двух чисел.</returns>
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    /// <summary>
    /// Выполняет деление двух чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Результат деления двух чисел.</returns>
    public int Divide(int a, int b)
    {
        return a / b;
    }
}