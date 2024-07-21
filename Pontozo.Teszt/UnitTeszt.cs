using Pontozo.Model;
using FluentAssertions;
namespace Pontozo.Teszt
{
    public class UnitTeszt
    {
        [Theory]
        [InlineData(1, "Teszt Elek", 1)]
        [InlineData(-25, "Minus", 1)]
        [InlineData(3, "Laci", -1)]
        [InlineData(1, "", 1)]
        public void AddPlayer(int ertek, string nev, int novekmeny)
        {
            Pont teszt = new Pont();
            teszt.Ertek = ertek;
            teszt.Name = nev;
            teszt.Novekmeny = novekmeny;

            teszt.Ertek.Should().BePositive();
            teszt.Name.Should().NotBeEmpty();
            teszt.Novekmeny.Should().BePositive();
        }
    }
}