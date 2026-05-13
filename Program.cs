string userChoice = string.Empty;
do
{
    Console.Write("Bir nechta sonlar ustida amallar \n \t 1: Bir xonalik sonlar ustida amallar \n\t 2: Turlik xonalik sonlar ustida amallar ");
    string str = Console.ReadLine();
    int userInput = Convert.ToInt32(str);
    switch (userInput)
    {
        case 1:
            {
                BirXonalikSonlar();
                break;
            }
        case 2:
            {
                IkkiXonalik();
                break;
            }
    }
}while(userChoice.ToLower()=="Yes");
static void BirXonalikSonlar()
{
    Console.Write("Bir xonalik sonlar ustida amallar:");
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
}
static void IkkiXonalik()
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
}