int MiddleNumber ( int number )
{
    number = number/10;
    int middleNumber = number%10;
    return middleNumber;
}


Console.Clear();
Console.WriteLine("Введите число: ");
int usernumber = Convert.ToInt32(Console.ReadLine());


if (usernumber/1000 == 0 & usernumber/100>0)
{
    int userMiddleNumber = MiddleNumber(usernumber);
    Console.WriteLine(userMiddleNumber);
}
else
{
    Console.WriteLine("Ошибкa");
}




