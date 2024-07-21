using Pontozo.Model;
using FluentAssertions;
namespace Pontozo.Teszt
{
    public class UnitTeszt
    {
        int alapErtek = 10;

        [Theory]
        [InlineData(3, "Laci",0)]
        [InlineData(1, "", 1)]
        public void AddPlayer_UresNev(int ertek, string nev, int novekmeny)
        {
            Pont teszt = new Pont();
            teszt.Ertek = ertek;
            teszt.Name = nev;
            teszt.Novekmeny = novekmeny;

            teszt.Name.Should().NotBeEmpty();
        }

        [Theory]
        [InlineData(3, "Laci", -10)]
        [InlineData(1, "Peti", 21)]
        public void AddPlayer_Novekmeny(int ertek, string nev, int novekmeny)
        {
            Pont teszt = new Pont();
            teszt.Ertek = ertek;
            teszt.Name = nev;
            teszt.Novekmeny = novekmeny;
            teszt.Novekmeny.Should().BePositive();
        }

        [Theory]
        [InlineData(1, "Teszt Elek", 1)]
        [InlineData(-25, "Minus", 1)]
        public void AddPlayer_Ertek(int ertek, string nev, int novekmeny)
        {
            Pont teszt = new Pont();
            teszt.Ertek = ertek;
            teszt.Name = nev;
            teszt.Novekmeny = novekmeny;

            teszt.Ertek.Should().BePositive();
        }

        [Theory]
        [InlineData( -1)]
        [InlineData(10)]
        public void IncrementValue(int novekmeny)
        {
            Pont teszt = new Pont();
            
            teszt.Ertek = alapErtek;
            teszt.Name = "Teszt Elek";
            teszt.Novekmeny = novekmeny;
            
            teszt.Ertek += teszt.Novekmeny;

            teszt.Ertek.Should().BeGreaterThan(alapErtek);
            teszt.Novekmeny.Should().BePositive();
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(5)]
        public void DecrementValue(int novekmeny)
        {
            Pont teszt = new Pont();

            teszt.Ertek = alapErtek;
            teszt.Name = "Teszt Elek";
            teszt.Novekmeny = novekmeny;

            teszt.Ertek -= teszt.Novekmeny;

            teszt.Ertek.Should().BeLessThan(alapErtek);
            teszt.Novekmeny.Should().BePositive();
        }
    }
}