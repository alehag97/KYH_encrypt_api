var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

int key = 3;

app.MapGet("/", () => "Hello World!");

app.MapGet("/encrypt", (string input) => Encrypt(input, key));

app.MapGet("/decrypt", (string input) => Decrypt(input, key));

app.Run();

string Encrypt(string input, int key)
{
    string encryptText = "";

    foreach (char c in input)
    {
        if (char.IsLetter(c))
        {
            char lowerC = char.ToLower(c);
            char keyed = (char)(((lowerC + key - 'a') % 26) + 'a');
            encryptText += keyed;
        }
        else
        {
            encryptText += c;
        }
    }
    return encryptText;
}

string Decrypt(string input, int key)
{
    string decryptText = "";

    foreach (char c in input)
    {
        if (char.IsLetter(c))
        {
            char lowerC = char.ToLower(c);
            char keyed = (char)(((lowerC - key - 'a' + 26) % 26) + 'a');
            decryptText += keyed;
        }
        else
        {
            decryptText += c;
        }
    }
    return decryptText;
}