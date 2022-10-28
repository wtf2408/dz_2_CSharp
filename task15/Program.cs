Console.Clear();
Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
string result = String.Empty;

string SixSeven (int number)
{
    if (number==6 || number==7 ) result = "да";
    else result = "нет";
    
    return result;
}
string answer = SixSeven(userNumber);
Console.Write($"{userNumber}-{answer}");

