using System;
using Xunit;


namespace gradebook.test;

public class  UnitTest1
{
    [Fact]
    public void Test1()
    {
      //arrange
      var x = 5;
      var y = 2;
      var expected = 7;



      //act
      var actual = x + y;


      //asset
      Assert.Equal(expected,actual);
    }
}