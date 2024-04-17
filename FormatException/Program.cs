string myStringVar = "hello123";
try
{
    int numStringVar = int.Parse(myStringVar);
    Console.WriteLine($"Huzzah, the conversion was a success, here ya go: {numStringVar}");
}
catch (FormatException e)
{
    Console.WriteLine($"Conversion failed: {e.Message}");
}
