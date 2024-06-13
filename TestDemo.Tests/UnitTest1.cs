namespace TestDemo.Tests;

public class UnitTest1
{
    [Fact]
    public void cifrado ()
    {
        string word = "HOLA";
        int k = 5;

        string ExpectedResult = "MTPF";

        string result = Algorithm.cifrado (word, k);

        Assert.Equal(ExpectedResult, result);
    }

    [Fact]
    
    public void descifrado()
    {
        string word = "MTPF";
        int k = 5;

        string expectedResult = "HOLA";

        string result2 = Algorithm.descifrado (word, k);

        Assert.Equal (expectedResult, result2); 

    }

    [Fact]
    public void cifrado ()
    {
        string word = "ZARAGOZA";
        int k = 5;

        string ExpectedResult = "5FWFLT5F";

        string result = Algorithm.cifrado (word, k);

        Assert.Equal(ExpectedResult, result);
    }

    [Fact]
    
    public void descifrado()
    {
        string word = "5FWFLT5F";
        int k = 5;

        string expectedResult = "ZARAGOZA";

        string result2 = Algorithm.descifrado (word, k);

        Assert.Equal (expectedResult, result2); 

    }

}
