Console.Write("Birnechta sonlar ustida amallar:");
string misol = Console.ReadLine();

int result = misol[0] - '0';

for (int i = 1; i < misol.Length; i += 2)
{
    char amal = misol[i];
    int son = misol[i + 1] - '0';

    if (amal == '+')
        result += son;
    else if (amal == '-')
        result -= son;
    else if (amal == '*')
        result *= son;
    else if (amal == '/')
        result /= son;
    else
    {
        Console.WriteLine("Manfiy  sonlarga ishlamaydi ");
    }   
}

Console.WriteLine("Natija: " + result);