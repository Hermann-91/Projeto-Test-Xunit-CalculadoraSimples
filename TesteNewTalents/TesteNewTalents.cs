using System;
using Xunit;
using NewTalents.Calculadora;

namespace TesteNewTalents;

public class TesteNewTalents
{
    public Calculadora construirClasse()
    {
        string data = "02/09/2025";
        Calculadora calc = new Calculadora("02/09/2025");
        return calc;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(20, 2, 22)]
    public void TestSomar(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.somar(val1, val2);

        Assert.Equal(resultadoCalculadora, resultado);

    }

    [Theory]
    [InlineData(4, 2, 2)]
    [InlineData(20, 2, 18)]
    public void TestSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.subtrair(val1, val2);

        Assert.Equal(resultadoCalculadora, resultado);

    }

    [Theory]
    [InlineData(5, 2, 10)]
    [InlineData(10, 2, 20)]
    public void TestMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.multiplicar(val1, val2);

        Assert.Equal(resultadoCalculadora, resultado);

    }

    [Theory]
    [InlineData(2, 2, 1)]
    [InlineData(20, 2, 10)]
    public void TestDividir(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.dividir(val1, val2);

        Assert.Equal(resultadoCalculadora, resultado);

    }

    [Theory]
    [InlineData(2, 2, 1)]
    [InlineData(20, 2, 10)]
    public void TestDividirPorZero(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
    }

    [Fact]
    public void TestarHistorico()
    {

        Calculadora calc = construirClasse();

        calc.somar(1, 2);
        calc.somar(2, 8);
        calc.somar(3, 7);
        calc.somar(4, 1);

        var lista = calc.historico();
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);

    }


}
