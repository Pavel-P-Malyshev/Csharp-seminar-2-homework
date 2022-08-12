/*
Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

void ShowThird(int value)
{
    
    List<int> digits=new List<int>();
    

    while(value>0)
    {
        digits.Add(value%10);
       
        value/=10;
        
    }
            
    if (digits.Count<3) {Console.WriteLine($"you number has only {digits.Count} digits, 3rd digit is zero! ");}
    else {Console.WriteLine($"3rd digit if your number is {digits[digits.Count-3]} ");}

    
    
        
}


int num=Prompt("Pls eneter your number: ");
ShowThird(num);

