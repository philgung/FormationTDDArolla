using FluentAssertions;

namespace LeapYearTests;

public class Tests
{
    // Leap Year
    // Write a function that returns true or false depending on whether
    // its input integer is a leap year or not
    // - A leap year is divisible by 4, but is not otherwise divisible
    // by 100
    // 1988 -> Typical Leap Year
    // 2001 -> Typical Common Year
    // 1992, 1996 -> Another Typical Leap Years
    // 1900 -> Atypical Common Year
    // - Unless it is also divisible by 400
    // 2000 -> Atypical Leap Year
    

    [Test]
    public void A_typical_leap_year()
    {
        var leapYear = LeapYear(1988);
        leapYear.Should().BeTrue();
    }

    private bool LeapYear(int year)
    {
        throw new System.NotImplementedException();
    }
}