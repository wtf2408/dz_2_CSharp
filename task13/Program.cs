int CheckLengthNumber (int number)
{
    if (number>99)
    {
       while (number>999)
       {
        number = number/10;
       } 
    }
    else
    {
        number=0;
    }
    return number;
}

int ThreeNumber (int numberx)
{
    int result = CheckLengthNumber(numberx);
    result = result%10;
    return result;
}

Console.Clear();
Console.Write("Введите число :  ");
int userNumber=Convert.ToInt32(Console.ReadLine());
userNumber = ThreeNumber(userNumber);
if (userNumber==0) 
Console.Write("третьей цифры нет");
else
Console.WriteLine(userNumber);

