using System.Collections;
using vcbmain.Controllers;
using vcbmain.Services;

namespace vcbtest;

[Trait("sprint", "2")]
public class NumberServiceTest
{
    public class NumberTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { Operators.Add, 1, 2, 3};
            yield return new object[] { Operators.Subtract, 1, 2, -1};
            yield return new object[] { Operators.Multiply, 1, 2, 2};
            yield return new object[] { Operators.Divide, 1, 2, 0.5};
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class NumberTestData2:TheoryData<Operators, int, int, double>
    {
        public NumberTestData2()
        {
            Add(Operators.Add,1,2,3);
            Add(Operators.Subtract,1,2,-1);
            Add(Operators.Multiply,1,2,2);
            Add(Operators.Divide,1,2,0.5);
        }
    }

    [Theory]
    //[ClassData(typeof(NumberTestData))]
    [ClassData(typeof(NumberTestData2))]
    public void Should_return_calculated_value_by_operator(Operators opt, int number1, int number2, double expected)
    {
        //Arrange
        NumberService numberService = new NumberService();
        //Act
        double actual = numberService.Calculate(opt, number1, number2);

        //Assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void shoul_return_exception_division_by_zero()
    {
        //Arrange
        int number1=1;
        int number2=0;

        NumberService numberService = new NumberService();

        //Assert
        Assert.Throws<DivideByZeroException>(()=>numberService.Calculate(Operators.Divide, number1, number2));
    }
}