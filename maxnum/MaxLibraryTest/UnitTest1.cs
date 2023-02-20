/* Deep Magrodia
   Dr Yulia Kumar 
   Tech 4982 - 01
   */

using Xunit;
using MaxNumberLibrary;

namespace MaxLibraryTest;

public class UnitTest1
{
    [Fact]
public void TestFindMaxWithTwoNumbers()
{
    // Arrange
    double num1 = 5.5;
    double num2 = 3.2;
    double expected = 5.5;

    // Act
    double actual = MaxNumberLibrary.MaxFinder.FindMax(num1, num2);

    // Assert
    Assert.Equal(expected, actual);
}
[Fact]
public void TestFindMaxWithThreeNumbers()
{
    // Arrange
    double num1 = 5.5;
    double num2 = 3.2;
    double num3 = 7.8;
    double expected = 7.8;

    // Act
    double actual = MaxNumberLibrary.MaxFinder.FindMax(num1, num2, num3);

    // Assert
    Assert.Equal(expected, actual);

}
}