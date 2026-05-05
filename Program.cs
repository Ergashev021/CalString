Console.WriteLine("Birnechta sonlar ustida amallar ");
string misol = Console.ReadLine();
int result = 0;
char son = misol[0];
char amal = misol[1];


for (int i =1; i < misol.Length+1; i+2);
{
    for (int j = 0; j < misol.Length+1;j+2)
    {
        if (misol[i] == "+")
        {
            result += misol[j];
        }
        else if(misol[i] == "-")
        {
            result-= misol[j];
        }
          else if(misol[i] == "*")
        {
            result *= misol[j];
        }
          else if(misol[i] == "/")
        {
            result /= misol[j];
        }
        else
        {
            Console.WriteLine("Natija Chiqmadi ");
        }
        
    }

}
Console.WriteLine("Natija : " + result);

