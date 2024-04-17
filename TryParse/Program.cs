string stringVar1 = "999";
if (int.TryParse(stringVar1, out int stringVar2))
{
    Console.WriteLine("Huzzah");
    Console.WriteLine(stringVar2);
}
else
{
    Console.WriteLine("booooo....conversion failure");
}