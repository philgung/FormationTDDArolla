using FluentAssertions;

namespace LeapYearTests;

public class Tests
{
    [TestCase(2001)]
    [TestCase(1900)]
    public void A_typical_common_year(int year)
    {
        var leapYear = LeapYear(year);
        leapYear.Should().BeFalse();
    }
    
    [TestCase(1988)]
    [TestCase(1992)]
    [TestCase(1996)]
    [TestCase(2000)]
    public void A_typical_leap_year(int year)
    {
        var leapYear = LeapYear(year);
        leapYear.Should().BeTrue();
    }
    

    private bool LeapYear(int year)
    {
        return (year.NEstPasDivisiblePar(100) && year.EstDivisiblePar(4)) || 
               (year.EstDivisiblePar(100) && year.EstDivisiblePar(400));
    }

}

public static class YearExtensions
{
    public static bool EstDivisiblePar(this int year, int valeur)
    {
        return year % valeur == 0;
    }
    public static bool NEstPasDivisiblePar(this int year, int valeur)
    {
        return year % valeur != 0;
    }

}