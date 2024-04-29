using Xunit;

public class StringManipulationTest
{
    [Fact]
    public void ConcatenateStrings()
    {
        // arrange
        var String_manipulate= new StringOperations();

        //act
        var result=String_manipulate.ConcatenateStrings("h","o");

        //Assert
        Assert.Equals("h  o",result);
    }
    [Fact]
    public void ReverseString()
    {
        // arrange
        var String_manipulate= new StringOperations();

        //act
        var result=String_manipulate.ReverseString("hola");

        //Assert
        Assert.Equals("aloh",result);
    }
    [Fact]
    public void GetStringLength()
    {
        // arrange
        var String_manipulate= new StringOperations();

        //act
        var result=String_manipulate.GetStringLength("hola");

        //Assert
        Assert.Equals(4,result);
    }
    [Fact]
    public void GetStringLength_null()
    {
        // arrange
        var String_manipulate= new StringOperations();

        //act & Assert
        Assert.throw<ArgumentNullException>(()=>String_manipulate.GetStringLength(null));
    }
    [Fact]
    public void RemoveWhitespace()
    {
        // arrange
        var String_manipulate= new StringOperations();

        //act
        var result=String_manipulate.RemoveWhitespace("hola mundo");

        //Assert
        Assert.Equals("holamundo",result);
    }
    [Fact]   
    public void TruncateString()
    {
        // arrange
        var String_manipulate= new StringOperations();

        //act
        var result=String_manipulate.TruncateString("hola mundo",6);

        //Assert
        Assert.Equals("hola m",result);
    }
    [Fact]   
    public void IsPalindrome()
    {
        // arrange
        var String_manipulate= new StringOperations();

        //act
        var result=String_manipulate.IsPalindrome("radar");

        //Assert
        Assert.True(result);
    }
    [Fact] 
    public void IsPalindrome_false()
    {
        // arrange
        var String_manipulate= new StringOperations();

        //act
        var result=String_manipulate.IsPalindrome("Hola");

        //Assert
        Assert.False(result);
    }
    [Fact] 
    public void CountOccurrences()
    {
        // arrange
        var String_manipulate= new StringOperations();

        //act
        var result=String_manipulate.CountOccurrences("banana",'n');

        //Assert
        Assert.Equals(2,result);
    }
    [Fact] 
    public void Pluralize()
    {
        // arrange
        var String_manipulate= new StringOperations();

        //act
        var result=String_manipulate.Pluralize("banana");

        //Assert
        Assert.Equals("bananas",result);
    }
    [Fact] 
    public void QuantintyInWords()
    {
        // arrange
        var String_manipulate= new StringOperations();

        //act
        var result=String_manipulate.QuantintyInWords("banana",5);

        //Assert
        Assert.Equals("five",result);
    }
    [Fact] 
    public void FromRomanToNumber()
    {
        // arrange
        var String_manipulate= new StringOperations();

        //act
        var result=String_manipulate.FromRomanToNumber("XV");

        //Assert
        Assert.Equals(15,result);
    }
    [Fact] 
    public void ReadFile()
    {
        // arrange
        var String_manipulate= new StringOperations();

        //act
        var result=String_manipulate.FromRomanToNumber("","information.txt");

        //Assert
        Assert.Equals("This is an information example",result);
    }


}