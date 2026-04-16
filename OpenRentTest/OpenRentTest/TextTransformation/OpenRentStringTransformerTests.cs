namespace OpenRentTest.TextTransformation;

public sealed class OpenRentStringTransformerTests
{
    [Theory]
    [InlineData("nepo", "openerent")]
    [InlineData("abc", "cbaaopen")]
    [InlineData("sky", "ykskrent")]
    [InlineData("rhythm", "mhtyhrhrent")]
    [InlineData("bcd", "dcbbrent")]
    public void Transform_ReturnsExpectedOutput_ForValidInput(string input, string expectedOutput)
    {
        string actualOutput = TransformInput(input);

        Assert.Equal(expectedOutput, actualOutput);
    }

    private string TransformInput(string input)
    {
        var reversedInput = new string(input.Reverse().ToArray());   
        var earliest = input.Min();
        var vowelCount = input.Count(c => "aeiou".Contains(c));
        var suffix = vowelCount % 2 == 1 ? "open" : "rent";
        return $"{reversedInput}{earliest}{suffix}";
    }
}






