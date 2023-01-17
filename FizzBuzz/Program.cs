// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(FB(3));


string FB(int num)
{
    string s = "";
    if (num % 3 == 0) { s += "fizz"; }
    if (num % 5 == 0) { s += "buzz"; }

    return s;
}
