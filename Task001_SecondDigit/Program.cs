/*
Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

int SecondDigit(int value)
{
    
    return value%100/10;
}
int A=Prompt("Enter you 3 digits number:");
while(A>999||A<100)
    { 
        Console.WriteLine("Your number has not 3 dogits, enter another:");
        A = Prompt("Enter you 3 digits number:");
    }
Console.WriteLine($"Second digit of your number is: {SecondDigit(A)}");