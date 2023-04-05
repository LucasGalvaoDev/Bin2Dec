using System;
using System.Diagnostics;

Console.WriteLine("######### Welcome To Bin2Dec #########");
Console.WriteLine();
Console.WriteLine("Enter a binary number of up to 8 digits to be converted");

try
{
    string digitos = Console.ReadLine();
    if (digitos?.Length > 8)
    {
        throw new Exception("Maximum limit of 8 digits. Please try again");
    }

    if (!VerificaZerosUns(digitos))
    {
        throw new Exception("Only 0 and 1 are allowed");
    }


    Console.WriteLine($"The decimal value referring to the binary numbers entered is equal to: {BinarioParaDecimal(digitos)}");
    Console.WriteLine();
    Console.WriteLine("Type any key to end");
    Console.ReadLine();

}
catch (Exception e)
{
    throw new Exception($"An error was found: {e.Message}");
}

static bool VerificaZerosUns(string str)
{
    foreach (char c in str)
    {
        if (c != '0' && c != '1')
        {
            return false;
        }
    }
    return true;
}
static int BinarioParaDecimal(string binario)
{
    int decimalValue = 0;
    int power = 0;
    for (int i = binario.Length - 1; i >= 0; i--)
    {
        int digit = binario[i] - '0';
        decimalValue += digit * (int)Math.Pow(2, power);
        power++;
    }
    return decimalValue;
}

