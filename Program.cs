using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

Console.Write("Birnechta  amallar \n\t 1: Bir xonalik sonlar ustida \n\t 2: Bir nechta xonalik sonlar ustida \n\t 3:Tartib hisoblash ");
string str = Console.ReadLine();
int userInput = Convert.ToInt32(str);
switch (userInput)
{
    case 1:
        {
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
            break;
        }
    case 2:
        {
            Console.Write("Misol kiriting: ");
            string misol = Console.ReadLine();

            int result = 0;
            int son = 0;
            char amal = '+';

            for (int i = 0; i < misol.Length; i++)
            {
                if (char.IsDigit(misol[i]))
                {
                    son = son * 10 + (misol[i] - '0');
                }

                if (!char.IsDigit(misol[i]) || i == misol.Length - 1)
                {
                    if (amal == '+')
                        result += son;
                    else if (amal == '-')
                        result -= son;
                    else if (amal == '*')
                        result *= son;
                    else if (amal == '/')
                        result /= son;

                    amal = misol[i];
                    son = 0;
                }
            }
            Console.WriteLine("Natija: " + result);
        
            break;
        }
        case 3:
        {
            // shufrlangan ma'lumot kriitadi uni ichida raqamlar va 
            //belgilardan tashkil topadi shularni raqamlarni ajratish kerak 
            // bizga kerak malumot kamida ikki marta takrorlangan 
            //shular  bziga kerak bolgan raqamlar shularni ajratib olishimiz kerak 
            Console.Write("Ma'lumotni kiriting : ");
            string matn = Console.ReadLine();
            string result = IsDigit(matn);
            string result1 = Info(result);
            Console.WriteLine("Natija : " + result1);

            break;
        }
} 
static string IsDigit(string text)
{
    string res ="";
    for (int i =0;i<text.Length;i++)
    {
        if (char.IsDigit(text[i]))
        {
            res +=text[i];
        }
    }
    return res;
}
static string Info(string num)
{
    string res1 ="";
    for (int i = 0; i < num.Length; i++)
    {
        
        int counter =0;
        if (char.IsDigit(num[i]))
        {
            for (int j = 0; j < num.Length; j++)
            {
                if (num[i] == num[j])
                {
                    counter++;
                }
            }
        }
         if (counter > 1 && !res1.Contains(num[i]))
        {
            res1 += num[i];
        }
            
    }
    return res1;
}


