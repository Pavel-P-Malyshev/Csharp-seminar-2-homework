/*
Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

bool IsHoliday(int value)
{
    
    return (value==6 | value==7);
     
        
}

string[] Week=new string [7] {"Mon", "Tue", "Wed","Thu", "Fri", "Sat", "Sun" };
    
int num=Prompt("Pls enter your number of a week day: ");
while(num<1 | num >7 )
{
    num=Prompt("Pls enter correct weekday number (from 1 to 7):  ");
}

if(IsHoliday(num)) {Console.WriteLine($"Great! Your day is {Week[num-1]} and it is holiday!");}
else {Console.WriteLine($"Your day is {Week[num-1]} and it is a working day :( ");}
