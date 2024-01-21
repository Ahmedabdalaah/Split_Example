// See https://aka.ms/new-console-template for more information
using Split_Example;

Spliit spl = new Spliit();
Console.WriteLine("Please Enter Your Input");
string input = Console.ReadLine();
Console.WriteLine(" pleace enter char to split");
string s = Console.ReadLine();
if (s.Length == 1)
{

    char splitc = Convert.ToChar(s);
    try
    {
        spl.splitW(input, splitc);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
else
{
    Console.WriteLine("Invalid Input");
}