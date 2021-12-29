namespace ConversaoKmParaMilhas.Testes;

public class TestesKmParaMilhas
{
    [Theory]
    [InlineData(1, 1.609)]
    [InlineData(2, 1.24274)]
    [InlineData(1300, 2091.7)]
    [InlineData(124, 77.05)]
    [InlineData(3582.324, 5763.959)]
    [InlineData(4661.28, 7500)]
    public void ValidarConversaoKmParaMilhas(
        double Km, double resultadoMilhas)
    {
        Assert.Equal(resultadoMilhas,
            ConversorDistancias.KmParaMilhas(Km));
    }
}
