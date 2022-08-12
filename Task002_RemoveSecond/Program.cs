/*
Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

int RemoveSecond()
{
    int randomnum=new Random().Next(100,1000);
    int[] digits=new int [3];
    int index=0;
    while(index<3)
    {
        digits[index]=randomnum%10;
        Console.WriteLine($"{index+1} digit of random value is {digits[index]}");
        randomnum/=10;
        index++;
    }
            
    return digits[0]*10+digits[2];
}


int result=RemoveSecond();
Console.WriteLine($"after second digit removal the result is {result}");
