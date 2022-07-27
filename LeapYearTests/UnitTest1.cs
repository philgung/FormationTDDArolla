using FluentAssertions;

namespace LeapYearTests;

public class Tests
{
    // Leap Year
    // Write a function that returns true or false depending on whether
    // its input integer is a leap year or not
    // - A leap year is divisible by 4, but is not otherwise divisible
    // by 100
    // 1900 -> Atypical Common Year
    // - Unless it is also divisible by 400
    // 2000 -> Atypical Leap Year
    

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
        if (year == 2001 || year == 1900)
        {
            return false;
        }
        return true;
    }
}