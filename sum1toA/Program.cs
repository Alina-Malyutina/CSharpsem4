int SumFromTo(int arg1)
{
    int summ = 0;

    /*int temp = 1;
     while (temp < arg1)
    {
        summ = summ + temp;
        temp++;
    }*/
    
    for(int i = 1; i<=arg1; i++)
    {
        summ = summ + i;
    }
    return summ; 
}

Console.WriteLine("This program assepts number and show sum numbers between 1 and number");
Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumFromTo(number);
Console.WriteLine(sum);

