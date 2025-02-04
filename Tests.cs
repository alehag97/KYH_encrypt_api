using Xunit;

public class UnitTests
{
    [Fact]
    public void TestValidEncryption()
    {
        // Given
        string input = "Hello! 1122";
        int key = 3;
        string expected = "khoor! 1122";
    
        // When
        string? result = Program.Encrypt(input, key);
    
        // Then
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestValidDecryption()
    {
        // Given
        string input = "khoor! 1122";
        int key = 3;
        string expected = "hello! 1122";
    
        // When
        string? result = Program.Decrypt(input, key);
    
        // Then
        Assert.Equal(expected, result);
    }
}